using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DMartOLTPUnitTestProject
{
    [TestClass()]
    public class uspUpdateEmployeeDetails : SqlDatabaseTestClass
    {

        public uspUpdateEmployeeDetails()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ChgFNOfEmp_1_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uspUpdateEmployeeDetails));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_1_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_1_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testInitializeAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testCleanupAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ChngLNOfEmp_2_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_2_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_2_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ChngADOfEmp_3_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_3_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_3_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_3_3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_1_4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AlcEmptoStr_4_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_4_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_4_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_4_3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ChngBGOfEmp_5_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_5_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_5_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ChngDesOfEmptoM_6_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_6_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_6_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition test_6_3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_6_4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ChngDesOfEmptoM_6_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Pre_6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpCdInvFl_7_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AlcEmptoStrNM_8_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_8_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_8_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_8_3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AlcEmptoStrNM_8_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition Pre_8_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ChgngDesOfEmptoMTr_9_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_9_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_9_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition test_9_3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_9_4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction ChgngDesOfEmptoMTr_9_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition pre_9_1;
            this.ChgFNOfEmp_1Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ChngLNOfEmp_2Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ChngADOfEmp_3Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.AlcEmptoStr_4Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ChngBGOfEmp_5Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ChngDesOfEmptoM_6Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.EmpCdInvFl_7Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.AlcEmptoStrNM_8Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.ChgngDesOfEmptoMTr_9Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            ChgFNOfEmp_1_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            test_1_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            test_1_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            testInitializeAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            testCleanupAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            ChngLNOfEmp_2_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            test_2_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            test_2_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            ChngADOfEmp_3_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            test_3_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            test_3_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            test_3_3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            test_1_4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            AlcEmptoStr_4_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            test_4_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            test_4_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            test_4_3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            ChngBGOfEmp_5_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            test_5_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            test_5_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            ChngDesOfEmptoM_6_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            test_6_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            test_6_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            test_6_3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            test_6_4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            ChngDesOfEmptoM_6_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Pre_6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            EmpCdInvFl_7_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            AlcEmptoStrNM_8_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            test_8_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            test_8_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            test_8_3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            AlcEmptoStrNM_8_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Pre_8_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            ChgngDesOfEmptoMTr_9_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            test_9_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            test_9_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            test_9_3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            test_9_4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            ChgngDesOfEmptoMTr_9_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            pre_9_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            // 
            // ChgFNOfEmp_1_TestAction
            // 
            ChgFNOfEmp_1_TestAction.Conditions.Add(test_1_1);
            ChgFNOfEmp_1_TestAction.Conditions.Add(test_1_2);
            resources.ApplyResources(ChgFNOfEmp_1_TestAction, "ChgFNOfEmp_1_TestAction");
            // 
            // test_1_1
            // 
            test_1_1.ColumnNumber = 1;
            test_1_1.Enabled = true;
            test_1_1.ExpectedValue = "CHANG";
            test_1_1.Name = "test_1_1";
            test_1_1.NullExpected = false;
            test_1_1.ResultSet = 1;
            test_1_1.RowNumber = 1;
            // 
            // test_1_2
            // 
            test_1_2.ColumnNumber = 1;
            test_1_2.Enabled = true;
            test_1_2.ExpectedValue = "0";
            test_1_2.Name = "test_1_2";
            test_1_2.NullExpected = false;
            test_1_2.ResultSet = 2;
            test_1_2.RowNumber = 1;
            // 
            // testInitializeAction
            // 
            resources.ApplyResources(testInitializeAction, "testInitializeAction");
            // 
            // testCleanupAction
            // 
            resources.ApplyResources(testCleanupAction, "testCleanupAction");
            // 
            // ChngLNOfEmp_2_TestAction
            // 
            ChngLNOfEmp_2_TestAction.Conditions.Add(test_2_1);
            ChngLNOfEmp_2_TestAction.Conditions.Add(test_2_2);
            resources.ApplyResources(ChngLNOfEmp_2_TestAction, "ChngLNOfEmp_2_TestAction");
            // 
            // test_2_1
            // 
            test_2_1.ColumnNumber = 1;
            test_2_1.Enabled = true;
            test_2_1.ExpectedValue = "ZONG";
            test_2_1.Name = "test_2_1";
            test_2_1.NullExpected = false;
            test_2_1.ResultSet = 1;
            test_2_1.RowNumber = 1;
            // 
            // test_2_2
            // 
            test_2_2.ColumnNumber = 1;
            test_2_2.Enabled = true;
            test_2_2.ExpectedValue = "0";
            test_2_2.Name = "test_2_2";
            test_2_2.NullExpected = false;
            test_2_2.ResultSet = 2;
            test_2_2.RowNumber = 1;
            // 
            // ChngADOfEmp_3_TestAction
            // 
            ChngADOfEmp_3_TestAction.Conditions.Add(test_3_1);
            ChngADOfEmp_3_TestAction.Conditions.Add(test_3_2);
            ChngADOfEmp_3_TestAction.Conditions.Add(test_3_3);
            ChngADOfEmp_3_TestAction.Conditions.Add(test_1_4);
            resources.ApplyResources(ChngADOfEmp_3_TestAction, "ChngADOfEmp_3_TestAction");
            // 
            // test_3_1
            // 
            test_3_1.ColumnNumber = 1;
            test_3_1.Enabled = true;
            test_3_1.ExpectedValue = "Change1";
            test_3_1.Name = "test_3_1";
            test_3_1.NullExpected = false;
            test_3_1.ResultSet = 1;
            test_3_1.RowNumber = 1;
            // 
            // test_3_2
            // 
            test_3_2.ColumnNumber = 2;
            test_3_2.Enabled = true;
            test_3_2.ExpectedValue = "Change2";
            test_3_2.Name = "test_3_2";
            test_3_2.NullExpected = false;
            test_3_2.ResultSet = 1;
            test_3_2.RowNumber = 1;
            // 
            // test_3_3
            // 
            test_3_3.ColumnNumber = 3;
            test_3_3.Enabled = true;
            test_3_3.ExpectedValue = "Change3";
            test_3_3.Name = "test_3_3";
            test_3_3.NullExpected = false;
            test_3_3.ResultSet = 1;
            test_3_3.RowNumber = 1;
            // 
            // test_1_4
            // 
            test_1_4.ColumnNumber = 1;
            test_1_4.Enabled = true;
            test_1_4.ExpectedValue = "0";
            test_1_4.Name = "test_1_4";
            test_1_4.NullExpected = false;
            test_1_4.ResultSet = 2;
            test_1_4.RowNumber = 1;
            // 
            // AlcEmptoStr_4_TestAction
            // 
            AlcEmptoStr_4_TestAction.Conditions.Add(test_4_1);
            AlcEmptoStr_4_TestAction.Conditions.Add(test_4_2);
            AlcEmptoStr_4_TestAction.Conditions.Add(test_4_3);
            resources.ApplyResources(AlcEmptoStr_4_TestAction, "AlcEmptoStr_4_TestAction");
            // 
            // test_4_1
            // 
            test_4_1.ColumnNumber = 1;
            test_4_1.Enabled = true;
            test_4_1.ExpectedValue = "2";
            test_4_1.Name = "test_4_1";
            test_4_1.NullExpected = false;
            test_4_1.ResultSet = 1;
            test_4_1.RowNumber = 1;
            // 
            // test_4_2
            // 
            test_4_2.ColumnNumber = 2;
            test_4_2.Enabled = true;
            test_4_2.ExpectedValue = "true";
            test_4_2.Name = "test_4_2";
            test_4_2.NullExpected = false;
            test_4_2.ResultSet = 1;
            test_4_2.RowNumber = 1;
            // 
            // test_4_3
            // 
            test_4_3.ColumnNumber = 1;
            test_4_3.Enabled = true;
            test_4_3.ExpectedValue = "0";
            test_4_3.Name = "test_4_3";
            test_4_3.NullExpected = false;
            test_4_3.ResultSet = 2;
            test_4_3.RowNumber = 1;
            // 
            // ChngBGOfEmp_5_TestAction
            // 
            ChngBGOfEmp_5_TestAction.Conditions.Add(test_5_1);
            ChngBGOfEmp_5_TestAction.Conditions.Add(test_5_2);
            resources.ApplyResources(ChngBGOfEmp_5_TestAction, "ChngBGOfEmp_5_TestAction");
            // 
            // test_5_1
            // 
            test_5_1.ColumnNumber = 1;
            test_5_1.Enabled = true;
            test_5_1.ExpectedValue = "A+";
            test_5_1.Name = "test_5_1";
            test_5_1.NullExpected = false;
            test_5_1.ResultSet = 1;
            test_5_1.RowNumber = 1;
            // 
            // test_5_2
            // 
            test_5_2.ColumnNumber = 1;
            test_5_2.Enabled = true;
            test_5_2.ExpectedValue = "0";
            test_5_2.Name = "test_5_2";
            test_5_2.NullExpected = false;
            test_5_2.ResultSet = 2;
            test_5_2.RowNumber = 1;
            // 
            // ChngDesOfEmptoM_6_TestAction
            // 
            ChngDesOfEmptoM_6_TestAction.Conditions.Add(test_6_1);
            ChngDesOfEmptoM_6_TestAction.Conditions.Add(test_6_2);
            ChngDesOfEmptoM_6_TestAction.Conditions.Add(test_6_3);
            ChngDesOfEmptoM_6_TestAction.Conditions.Add(test_6_4);
            resources.ApplyResources(ChngDesOfEmptoM_6_TestAction, "ChngDesOfEmptoM_6_TestAction");
            // 
            // test_6_1
            // 
            test_6_1.ColumnNumber = 1;
            test_6_1.Enabled = true;
            test_6_1.ExpectedValue = "true";
            test_6_1.Name = "test_6_1";
            test_6_1.NullExpected = false;
            test_6_1.ResultSet = 1;
            test_6_1.RowNumber = 1;
            // 
            // test_6_2
            // 
            test_6_2.ColumnNumber = 2;
            test_6_2.Enabled = true;
            test_6_2.ExpectedValue = "Manager";
            test_6_2.Name = "test_6_2";
            test_6_2.NullExpected = false;
            test_6_2.ResultSet = 1;
            test_6_2.RowNumber = 1;
            // 
            // test_6_3
            // 
            test_6_3.Enabled = true;
            test_6_3.Name = "test_6_3";
            test_6_3.ResultSet = 2;
            test_6_3.RowCount = 0;
            // 
            // test_6_4
            // 
            test_6_4.ColumnNumber = 1;
            test_6_4.Enabled = true;
            test_6_4.ExpectedValue = "0";
            test_6_4.Name = "test_6_4";
            test_6_4.NullExpected = false;
            test_6_4.ResultSet = 3;
            test_6_4.RowNumber = 1;
            // 
            // ChngDesOfEmptoM_6_PretestAction
            // 
            ChngDesOfEmptoM_6_PretestAction.Conditions.Add(Pre_6);
            resources.ApplyResources(ChngDesOfEmptoM_6_PretestAction, "ChngDesOfEmptoM_6_PretestAction");
            // 
            // Pre_6
            // 
            Pre_6.Enabled = true;
            Pre_6.Name = "Pre_6";
            Pre_6.ResultSet = 1;
            Pre_6.RowCount = 0;
            // 
            // EmpCdInvFl_7_TestAction
            // 
            resources.ApplyResources(EmpCdInvFl_7_TestAction, "EmpCdInvFl_7_TestAction");
            // 
            // AlcEmptoStrNM_8_TestAction
            // 
            AlcEmptoStrNM_8_TestAction.Conditions.Add(test_8_1);
            AlcEmptoStrNM_8_TestAction.Conditions.Add(test_8_2);
            AlcEmptoStrNM_8_TestAction.Conditions.Add(test_8_3);
            resources.ApplyResources(AlcEmptoStrNM_8_TestAction, "AlcEmptoStrNM_8_TestAction");
            // 
            // test_8_1
            // 
            test_8_1.ColumnNumber = 1;
            test_8_1.Enabled = true;
            test_8_1.ExpectedValue = "1";
            test_8_1.Name = "test_8_1";
            test_8_1.NullExpected = false;
            test_8_1.ResultSet = 1;
            test_8_1.RowNumber = 1;
            // 
            // test_8_2
            // 
            test_8_2.ColumnNumber = 2;
            test_8_2.Enabled = true;
            test_8_2.ExpectedValue = "true";
            test_8_2.Name = "test_8_2";
            test_8_2.NullExpected = false;
            test_8_2.ResultSet = 1;
            test_8_2.RowNumber = 1;
            // 
            // test_8_3
            // 
            test_8_3.ColumnNumber = 1;
            test_8_3.Enabled = true;
            test_8_3.ExpectedValue = "0";
            test_8_3.Name = "test_8_3";
            test_8_3.NullExpected = false;
            test_8_3.ResultSet = 2;
            test_8_3.RowNumber = 1;
            // 
            // AlcEmptoStrNM_8_PretestAction
            // 
            AlcEmptoStrNM_8_PretestAction.Conditions.Add(Pre_8_1);
            resources.ApplyResources(AlcEmptoStrNM_8_PretestAction, "AlcEmptoStrNM_8_PretestAction");
            // 
            // Pre_8_1
            // 
            Pre_8_1.Enabled = true;
            Pre_8_1.Name = "Pre_8_1";
            Pre_8_1.ResultSet = 1;
            // 
            // ChgngDesOfEmptoMTr_9_TestAction
            // 
            ChgngDesOfEmptoMTr_9_TestAction.Conditions.Add(test_9_1);
            ChgngDesOfEmptoMTr_9_TestAction.Conditions.Add(test_9_2);
            ChgngDesOfEmptoMTr_9_TestAction.Conditions.Add(test_9_3);
            ChgngDesOfEmptoMTr_9_TestAction.Conditions.Add(test_9_4);
            resources.ApplyResources(ChgngDesOfEmptoMTr_9_TestAction, "ChgngDesOfEmptoMTr_9_TestAction");
            // 
            // test_9_1
            // 
            test_9_1.ColumnNumber = 1;
            test_9_1.Enabled = true;
            test_9_1.ExpectedValue = "true";
            test_9_1.Name = "test_9_1";
            test_9_1.NullExpected = false;
            test_9_1.ResultSet = 1;
            test_9_1.RowNumber = 1;
            // 
            // test_9_2
            // 
            test_9_2.ColumnNumber = 2;
            test_9_2.Enabled = true;
            test_9_2.ExpectedValue = "Manager";
            test_9_2.Name = "test_9_2";
            test_9_2.NullExpected = false;
            test_9_2.ResultSet = 1;
            test_9_2.RowNumber = 1;
            // 
            // test_9_3
            // 
            test_9_3.Enabled = true;
            test_9_3.Name = "test_9_3";
            test_9_3.ResultSet = 2;
            test_9_3.RowCount = 2;
            // 
            // test_9_4
            // 
            test_9_4.ColumnNumber = 1;
            test_9_4.Enabled = true;
            test_9_4.ExpectedValue = "0";
            test_9_4.Name = "test_9_4";
            test_9_4.NullExpected = false;
            test_9_4.ResultSet = 3;
            test_9_4.RowNumber = 1;
            // 
            // ChgngDesOfEmptoMTr_9_PretestAction
            // 
            ChgngDesOfEmptoMTr_9_PretestAction.Conditions.Add(pre_9_1);
            resources.ApplyResources(ChgngDesOfEmptoMTr_9_PretestAction, "ChgngDesOfEmptoMTr_9_PretestAction");
            // 
            // pre_9_1
            // 
            pre_9_1.Enabled = true;
            pre_9_1.Name = "pre_9_1";
            pre_9_1.ResultSet = 1;
            // 
            // ChgFNOfEmp_1Data
            // 
            this.ChgFNOfEmp_1Data.PosttestAction = null;
            this.ChgFNOfEmp_1Data.PretestAction = null;
            this.ChgFNOfEmp_1Data.TestAction = ChgFNOfEmp_1_TestAction;
            // 
            // ChngLNOfEmp_2Data
            // 
            this.ChngLNOfEmp_2Data.PosttestAction = null;
            this.ChngLNOfEmp_2Data.PretestAction = null;
            this.ChngLNOfEmp_2Data.TestAction = ChngLNOfEmp_2_TestAction;
            // 
            // ChngADOfEmp_3Data
            // 
            this.ChngADOfEmp_3Data.PosttestAction = null;
            this.ChngADOfEmp_3Data.PretestAction = null;
            this.ChngADOfEmp_3Data.TestAction = ChngADOfEmp_3_TestAction;
            // 
            // AlcEmptoStr_4Data
            // 
            this.AlcEmptoStr_4Data.PosttestAction = null;
            this.AlcEmptoStr_4Data.PretestAction = null;
            this.AlcEmptoStr_4Data.TestAction = AlcEmptoStr_4_TestAction;
            // 
            // ChngBGOfEmp_5Data
            // 
            this.ChngBGOfEmp_5Data.PosttestAction = null;
            this.ChngBGOfEmp_5Data.PretestAction = null;
            this.ChngBGOfEmp_5Data.TestAction = ChngBGOfEmp_5_TestAction;
            // 
            // ChngDesOfEmptoM_6Data
            // 
            this.ChngDesOfEmptoM_6Data.PosttestAction = null;
            this.ChngDesOfEmptoM_6Data.PretestAction = ChngDesOfEmptoM_6_PretestAction;
            this.ChngDesOfEmptoM_6Data.TestAction = ChngDesOfEmptoM_6_TestAction;
            // 
            // EmpCdInvFl_7Data
            // 
            this.EmpCdInvFl_7Data.PosttestAction = null;
            this.EmpCdInvFl_7Data.PretestAction = null;
            this.EmpCdInvFl_7Data.TestAction = EmpCdInvFl_7_TestAction;
            // 
            // AlcEmptoStrNM_8Data
            // 
            this.AlcEmptoStrNM_8Data.PosttestAction = null;
            this.AlcEmptoStrNM_8Data.PretestAction = AlcEmptoStrNM_8_PretestAction;
            this.AlcEmptoStrNM_8Data.TestAction = AlcEmptoStrNM_8_TestAction;
            // 
            // ChgngDesOfEmptoMTr_9Data
            // 
            this.ChgngDesOfEmptoMTr_9Data.PosttestAction = null;
            this.ChgngDesOfEmptoMTr_9Data.PretestAction = ChgngDesOfEmptoMTr_9_PretestAction;
            this.ChgngDesOfEmptoMTr_9Data.TestAction = ChgngDesOfEmptoMTr_9_TestAction;
            // 
            // uspUpdateEmployeeDetails
            // 
            this.TestCleanupAction = testCleanupAction;
            this.TestInitializeAction = testInitializeAction;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void ChgFNOfEmp_1()
        {
            SqlDatabaseTestActions testActions = this.ChgFNOfEmp_1Data;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void ChngLNOfEmp_2()
        {
            SqlDatabaseTestActions testActions = this.ChngLNOfEmp_2Data;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void ChngADOfEmp_3()
        {
            SqlDatabaseTestActions testActions = this.ChngADOfEmp_3Data;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void AlcEmptoStr_4()
        {
            SqlDatabaseTestActions testActions = this.AlcEmptoStr_4Data;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void ChngBGOfEmp_5()
        {
            SqlDatabaseTestActions testActions = this.ChngBGOfEmp_5Data;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void ChngDesOfEmptoM_6()
        {
            SqlDatabaseTestActions testActions = this.ChngDesOfEmptoM_6Data;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod(), ExpectedSqlException(MatchFirstError =false, MessageNumber =50001, Severity =19, State =1)]
        public void EmpCdInvFl_7()
        {
            SqlDatabaseTestActions testActions = this.EmpCdInvFl_7Data;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void AlcEmptoStrNM_8()
        {
            SqlDatabaseTestActions testActions = this.AlcEmptoStrNM_8Data;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        [TestMethod()]
        public void ChgngDesOfEmptoMTr_9()
        {
            SqlDatabaseTestActions testActions = this.ChgngDesOfEmptoMTr_9Data;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }








        private SqlDatabaseTestActions ChgFNOfEmp_1Data;
        private SqlDatabaseTestActions ChngLNOfEmp_2Data;
        private SqlDatabaseTestActions ChngADOfEmp_3Data;
        private SqlDatabaseTestActions AlcEmptoStr_4Data;
        private SqlDatabaseTestActions ChngBGOfEmp_5Data;
        private SqlDatabaseTestActions ChngDesOfEmptoM_6Data;
        private SqlDatabaseTestActions EmpCdInvFl_7Data;
        private SqlDatabaseTestActions AlcEmptoStrNM_8Data;
        private SqlDatabaseTestActions ChgngDesOfEmptoMTr_9Data;
    }
}
