using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Rappen.XRM.Helpers.Extensions;
using Rappen.XTB.Helpers.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace Bizz22
{
    public partial class MyPluginControl : PluginControlBase
    {
        public MyPluginControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_ConnectionUpdated(object sender, ConnectionUpdatedEventArgs e)
        {
            xrmView.Service = e.Service;
            xrmData.Service = e.Service;
            xrmRecordHost1.Service = e.Service;
            GetEntities();
        }

        private void GetEntities()
        {
            // A bit faster
            xrmTable.DataSource = Service.LoadEntities().EntityMetadata
                .Where(e => e.IsManaged.Value == false || chkManaged.Checked);

            // A bit better
            //this.GetAllEntityMetadatas((em) =>
            //{
            //    xrmEntityComboBox1.DataSource = em
            //      .Where(e => e.IsManaged.Value == false || checkBox1.Checked);;
            //});
        }

        private void chkManaged_CheckedChanged(object sender, EventArgs e)
        {
            GetEntities();
        }

        private void xrmTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetViews();
        }

        private void GetViews()
        {
            var entity = xrmTable.SelectedEntity;
            xrmPrimaryName.Column = entity?.PrimaryNameAttribute;

            if (entity == null) { return; }

            var query_statecode = 0;
            var query = new QueryExpression("savedquery");
            query.ColumnSet.AddColumns("name", "fetchxml", "layoutxml");
            query.Criteria.AddCondition("statecode", ConditionOperator.Equal, query_statecode);
            query.Criteria.AddCondition("fetchxml", ConditionOperator.NotNull);
            query.Criteria.AddCondition("returnedtypecode", ConditionOperator.Equal, entity.LogicalName);

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading Views..",
                Work = (worker, args) =>
                {
                    args.Result = Service.RetrieveMultiple(query);
                },
                PostWorkCallBack = (args) =>
                {
                    ShowErrorDialog(args.Error);
                    if (args.Error == null && args.Result is EntityCollection views)
                    {
                        xrmView.DataSource = views;
                    }
                }
            });
        }

        private void xrmView_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            var fetch = xrmView.SelectedRecord?.GetAttributeValue<string>("fetchxml");
            var layout = xrmView.SelectedRecord?.GetAttributeValue<string>("layoutxml");
            if (string.IsNullOrEmpty(fetch)) { return; }

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading Data..",
                Work = (worker, args) =>
                {
                    xrmData.SetDataSource(fetch, layout);
                    //          args.Result = Service.RetrieveMultiple(new FetchExpression(fetch));
                },
                PostWorkCallBack = (args) =>
                {
                    ShowErrorDialog(args.Error);
                    if (args.Error == null && args.Result is EntityCollection views)
                    {
                        xrmData.DataSource = views;
                    }
                }
            });
        }

        private void chkFriendly_CheckedChanged(object sender, EventArgs e)
        {
            xrmData.ShowFriendlyNames = chkFriendly.Checked;
        }

        private void xrmData_RecordClick(object sender, Rappen.XTB.Helpers.Controls.XRMRecordEventArgs e)
        {
            xrmRecordHost1.Record = e.Entity;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Saving...",
                Work = (work, args) =>
                {
                    args.Result = xrmRecordHost1.SaveChanges();
                },
                PostWorkCallBack = (args) =>
                {
                    ShowErrorDialog(args.Error);
                    if (args.Error == null && args.Result is bool result && result)
                    {
                        GetData();
                    }
                }
            });
        }
    }
}