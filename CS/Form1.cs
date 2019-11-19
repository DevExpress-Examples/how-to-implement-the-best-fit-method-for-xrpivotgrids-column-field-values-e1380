﻿using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UI.CrossTab;
using System;
using System.Windows.Forms;
// ...

namespace RepPGVertHeadersHeight {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Fill a SqlDataSource asynchronously
            sqlDataSource1.Fill();
        }

        private void button1_Click(object sender, EventArgs e) {
            //Apply Best Fit to "CategoryName" column
            pivotGridControl1.Fields["CategoryName"].BestFit();
        }

        private void button2_Click(object sender, EventArgs e) {
            using (XtraReport report = new XtraReport1())
            using (ReportPrintTool tool = new ReportPrintTool(report)) {

                XRCrossTab crossTab = report.FindControl("xrCrossTab1", false) as XRCrossTab;

                //Apply Best Fit to "CategoryName" column (Cell named "cellCategoryName" in XRCrossTab)
                (crossTab.Cells["cellCategoryName"] as XRCrossTabCell).ColumnAutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow;
               

                tool.ShowPreviewDialog();
            }
        }
    }
}