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
    public class uspRemovePhoneNumber : SqlDatabaseTestClass
    {

        public uspRemovePhoneNumber()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpNPPhSing_1_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uspRemovePhoneNumber));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testCleanupAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpNPPhSing_1_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Pre_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StrNPPhSing_2_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Test_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StrNPPhSing_2_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Pre_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpPriWoAlFl_3_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpPriWoAlFl_3_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Pre_3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StrPriWoAlFl_4_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StrPriWoAlFl_4_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Pre_4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpPriWtAlPs_5_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Test_5_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Test_5_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpPriWtAlPs_5_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Pre_5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StrPriWtAlPs_6_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Test_6_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Test_6_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StrPriWtAlPs_6_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Pre_6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpOnPhFl_7_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpOnPhFl_7_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Pre_7;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StrOnPhFl_8_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StrOnPhFl_8_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Pre_8;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpMulPhRm_9_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Test_9;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpMulPhRm_9_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Pre_9;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StrMulPhRm_10_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Test_10;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StrMulPhRm_10_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Pre_10;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpDelAll_11_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Test_11;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpDelAll_11_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Pre_11;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StrDelAllFl_12_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StrDelAllFl_12_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Pre_12;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpPriWoPrFl_13_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpPriWoPrFl_13_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Pre_13;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StrPriWoPrFl_14_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StrPriWoPrFl_14_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Pre_14;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_1;
            this.EmpNPPhSing_1Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StrNPPhSing_2Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.EmpPriWoAlFl_3Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StrPriWoAlFl_4Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.EmpPriWtAlPs_5Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StrPriWtAlPs_6Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.EmpOnPhFl_7Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StrOnPhFl_8Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.EmpMulPhRm_9Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StrMulPhRm_10Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.EmpDelAll_11Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StrDelAllFl_12Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.EmpPriWoPrFl_13Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StrPriWoPrFl_14Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            EmpNPPhSing_1_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            testCleanupAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            EmpNPPhSing_1_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Pre_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            StrNPPhSing_2_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Test_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            StrNPPhSing_2_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Pre_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            EmpPriWoAlFl_3_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            EmpPriWoAlFl_3_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Pre_3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            StrPriWoAlFl_4_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            StrPriWoAlFl_4_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Pre_4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            EmpPriWtAlPs_5_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Test_5_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            Test_5_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            EmpPriWtAlPs_5_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Pre_5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            StrPriWtAlPs_6_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Test_6_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            Test_6_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            StrPriWtAlPs_6_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Pre_6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            EmpOnPhFl_7_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            EmpOnPhFl_7_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Pre_7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            StrOnPhFl_8_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            StrOnPhFl_8_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Pre_8 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            EmpMulPhRm_9_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Test_9 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            EmpMulPhRm_9_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Pre_9 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            StrMulPhRm_10_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Test_10 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            StrMulPhRm_10_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Pre_10 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            EmpDelAll_11_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Test_11 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            EmpDelAll_11_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Pre_11 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            StrDelAllFl_12_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            StrDelAllFl_12_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Pre_12 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            EmpPriWoPrFl_13_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            EmpPriWoPrFl_13_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Pre_13 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            StrPriWoPrFl_14_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            StrPriWoPrFl_14_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Pre_14 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            Test_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // EmpNPPhSing_1_TestAction
            // 
            EmpNPPhSing_1_TestAction.Conditions.Add(Test_1);
            resources.ApplyResources(EmpNPPhSing_1_TestAction, "EmpNPPhSing_1_TestAction");
            // 
            // testCleanupAction
            // 
            resources.ApplyResources(testCleanupAction, "testCleanupAction");
            // 
            // EmpNPPhSing_1_PretestAction
            // 
            EmpNPPhSing_1_PretestAction.Conditions.Add(Pre_1);
            resources.ApplyResources(EmpNPPhSing_1_PretestAction, "EmpNPPhSing_1_PretestAction");
            // 
            // Pre_1
            // 
            Pre_1.Enabled = true;
            Pre_1.Name = "Pre_1";
            Pre_1.ResultSet = 1;
            Pre_1.RowCount = 3;
            // 
            // StrNPPhSing_2_TestAction
            // 
            StrNPPhSing_2_TestAction.Conditions.Add(Test_2);
            resources.ApplyResources(StrNPPhSing_2_TestAction, "StrNPPhSing_2_TestAction");
            // 
            // Test_2
            // 
            Test_2.Enabled = true;
            Test_2.Name = "Test_2";
            Test_2.ResultSet = 1;
            Test_2.RowCount = 2;
            // 
            // StrNPPhSing_2_PretestAction
            // 
            StrNPPhSing_2_PretestAction.Conditions.Add(Pre_2);
            resources.ApplyResources(StrNPPhSing_2_PretestAction, "StrNPPhSing_2_PretestAction");
            // 
            // Pre_2
            // 
            Pre_2.Enabled = true;
            Pre_2.Name = "Pre_2";
            Pre_2.ResultSet = 1;
            Pre_2.RowCount = 3;
            // 
            // EmpPriWoAlFl_3_TestAction
            // 
            resources.ApplyResources(EmpPriWoAlFl_3_TestAction, "EmpPriWoAlFl_3_TestAction");
            // 
            // EmpPriWoAlFl_3_PretestAction
            // 
            EmpPriWoAlFl_3_PretestAction.Conditions.Add(Pre_3);
            resources.ApplyResources(EmpPriWoAlFl_3_PretestAction, "EmpPriWoAlFl_3_PretestAction");
            // 
            // Pre_3
            // 
            Pre_3.Enabled = true;
            Pre_3.Name = "Pre_3";
            Pre_3.ResultSet = 1;
            Pre_3.RowCount = 3;
            // 
            // StrPriWoAlFl_4_TestAction
            // 
            resources.ApplyResources(StrPriWoAlFl_4_TestAction, "StrPriWoAlFl_4_TestAction");
            // 
            // StrPriWoAlFl_4_PretestAction
            // 
            StrPriWoAlFl_4_PretestAction.Conditions.Add(Pre_4);
            resources.ApplyResources(StrPriWoAlFl_4_PretestAction, "StrPriWoAlFl_4_PretestAction");
            // 
            // Pre_4
            // 
            Pre_4.Enabled = true;
            Pre_4.Name = "Pre_4";
            Pre_4.ResultSet = 1;
            Pre_4.RowCount = 3;
            // 
            // EmpPriWtAlPs_5_TestAction
            // 
            EmpPriWtAlPs_5_TestAction.Conditions.Add(Test_5_1);
            EmpPriWtAlPs_5_TestAction.Conditions.Add(Test_5_2);
            resources.ApplyResources(EmpPriWtAlPs_5_TestAction, "EmpPriWtAlPs_5_TestAction");
            // 
            // Test_5_1
            // 
            Test_5_1.Enabled = true;
            Test_5_1.Name = "Test_5_1";
            Test_5_1.ResultSet = 1;
            Test_5_1.RowCount = 2;
            // 
            // Test_5_2
            // 
            Test_5_2.Enabled = true;
            Test_5_2.Name = "Test_5_2";
            Test_5_2.ResultSet = 2;
            Test_5_2.RowCount = 1;
            // 
            // EmpPriWtAlPs_5_PretestAction
            // 
            EmpPriWtAlPs_5_PretestAction.Conditions.Add(Pre_5);
            resources.ApplyResources(EmpPriWtAlPs_5_PretestAction, "EmpPriWtAlPs_5_PretestAction");
            // 
            // Pre_5
            // 
            Pre_5.Enabled = true;
            Pre_5.Name = "Pre_5";
            Pre_5.ResultSet = 1;
            Pre_5.RowCount = 3;
            // 
            // StrPriWtAlPs_6_TestAction
            // 
            StrPriWtAlPs_6_TestAction.Conditions.Add(Test_6_1);
            StrPriWtAlPs_6_TestAction.Conditions.Add(Test_6_2);
            resources.ApplyResources(StrPriWtAlPs_6_TestAction, "StrPriWtAlPs_6_TestAction");
            // 
            // Test_6_1
            // 
            Test_6_1.Enabled = true;
            Test_6_1.Name = "Test_6_1";
            Test_6_1.ResultSet = 1;
            Test_6_1.RowCount = 2;
            // 
            // Test_6_2
            // 
            Test_6_2.Enabled = true;
            Test_6_2.Name = "Test_6_2";
            Test_6_2.ResultSet = 2;
            Test_6_2.RowCount = 1;
            // 
            // StrPriWtAlPs_6_PretestAction
            // 
            StrPriWtAlPs_6_PretestAction.Conditions.Add(Pre_6);
            resources.ApplyResources(StrPriWtAlPs_6_PretestAction, "StrPriWtAlPs_6_PretestAction");
            // 
            // Pre_6
            // 
            Pre_6.Enabled = true;
            Pre_6.Name = "Pre_6";
            Pre_6.ResultSet = 1;
            Pre_6.RowCount = 3;
            // 
            // EmpOnPhFl_7_TestAction
            // 
            resources.ApplyResources(EmpOnPhFl_7_TestAction, "EmpOnPhFl_7_TestAction");
            // 
            // EmpOnPhFl_7_PretestAction
            // 
            EmpOnPhFl_7_PretestAction.Conditions.Add(Pre_7);
            resources.ApplyResources(EmpOnPhFl_7_PretestAction, "EmpOnPhFl_7_PretestAction");
            // 
            // Pre_7
            // 
            Pre_7.Enabled = true;
            Pre_7.Name = "Pre_7";
            Pre_7.ResultSet = 1;
            Pre_7.RowCount = 1;
            // 
            // StrOnPhFl_8_TestAction
            // 
            resources.ApplyResources(StrOnPhFl_8_TestAction, "StrOnPhFl_8_TestAction");
            // 
            // StrOnPhFl_8_PretestAction
            // 
            StrOnPhFl_8_PretestAction.Conditions.Add(Pre_8);
            resources.ApplyResources(StrOnPhFl_8_PretestAction, "StrOnPhFl_8_PretestAction");
            // 
            // Pre_8
            // 
            Pre_8.Enabled = true;
            Pre_8.Name = "Pre_8";
            Pre_8.ResultSet = 1;
            Pre_8.RowCount = 1;
            // 
            // EmpMulPhRm_9_TestAction
            // 
            EmpMulPhRm_9_TestAction.Conditions.Add(Test_9);
            resources.ApplyResources(EmpMulPhRm_9_TestAction, "EmpMulPhRm_9_TestAction");
            // 
            // Test_9
            // 
            Test_9.Enabled = true;
            Test_9.Name = "Test_9";
            Test_9.ResultSet = 1;
            Test_9.RowCount = 1;
            // 
            // EmpMulPhRm_9_PretestAction
            // 
            EmpMulPhRm_9_PretestAction.Conditions.Add(Pre_9);
            resources.ApplyResources(EmpMulPhRm_9_PretestAction, "EmpMulPhRm_9_PretestAction");
            // 
            // Pre_9
            // 
            Pre_9.Enabled = true;
            Pre_9.Name = "Pre_9";
            Pre_9.ResultSet = 1;
            Pre_9.RowCount = 3;
            // 
            // StrMulPhRm_10_TestAction
            // 
            StrMulPhRm_10_TestAction.Conditions.Add(Test_10);
            resources.ApplyResources(StrMulPhRm_10_TestAction, "StrMulPhRm_10_TestAction");
            // 
            // Test_10
            // 
            Test_10.Enabled = true;
            Test_10.Name = "Test_10";
            Test_10.ResultSet = 1;
            Test_10.RowCount = 1;
            // 
            // StrMulPhRm_10_PretestAction
            // 
            StrMulPhRm_10_PretestAction.Conditions.Add(Pre_10);
            resources.ApplyResources(StrMulPhRm_10_PretestAction, "StrMulPhRm_10_PretestAction");
            // 
            // Pre_10
            // 
            Pre_10.Enabled = true;
            Pre_10.Name = "Pre_10";
            Pre_10.ResultSet = 1;
            Pre_10.RowCount = 3;
            // 
            // EmpDelAll_11_TestAction
            // 
            EmpDelAll_11_TestAction.Conditions.Add(Test_11);
            resources.ApplyResources(EmpDelAll_11_TestAction, "EmpDelAll_11_TestAction");
            // 
            // Test_11
            // 
            Test_11.Enabled = true;
            Test_11.Name = "Test_11";
            Test_11.ResultSet = 1;
            Test_11.RowCount = 0;
            // 
            // EmpDelAll_11_PretestAction
            // 
            EmpDelAll_11_PretestAction.Conditions.Add(Pre_11);
            resources.ApplyResources(EmpDelAll_11_PretestAction, "EmpDelAll_11_PretestAction");
            // 
            // Pre_11
            // 
            Pre_11.Enabled = true;
            Pre_11.Name = "Pre_11";
            Pre_11.ResultSet = 1;
            Pre_11.RowCount = 3;
            // 
            // StrDelAllFl_12_TestAction
            // 
            resources.ApplyResources(StrDelAllFl_12_TestAction, "StrDelAllFl_12_TestAction");
            // 
            // StrDelAllFl_12_PretestAction
            // 
            StrDelAllFl_12_PretestAction.Conditions.Add(Pre_12);
            resources.ApplyResources(StrDelAllFl_12_PretestAction, "StrDelAllFl_12_PretestAction");
            // 
            // Pre_12
            // 
            Pre_12.Enabled = true;
            Pre_12.Name = "Pre_12";
            Pre_12.ResultSet = 1;
            Pre_12.RowCount = 3;
            // 
            // EmpPriWoPrFl_13_TestAction
            // 
            resources.ApplyResources(EmpPriWoPrFl_13_TestAction, "EmpPriWoPrFl_13_TestAction");
            // 
            // EmpPriWoPrFl_13_PretestAction
            // 
            EmpPriWoPrFl_13_PretestAction.Conditions.Add(Pre_13);
            resources.ApplyResources(EmpPriWoPrFl_13_PretestAction, "EmpPriWoPrFl_13_PretestAction");
            // 
            // Pre_13
            // 
            Pre_13.Enabled = true;
            Pre_13.Name = "Pre_13";
            Pre_13.ResultSet = 1;
            Pre_13.RowCount = 3;
            // 
            // StrPriWoPrFl_14_TestAction
            // 
            resources.ApplyResources(StrPriWoPrFl_14_TestAction, "StrPriWoPrFl_14_TestAction");
            // 
            // StrPriWoPrFl_14_PretestAction
            // 
            StrPriWoPrFl_14_PretestAction.Conditions.Add(Pre_14);
            resources.ApplyResources(StrPriWoPrFl_14_PretestAction, "StrPriWoPrFl_14_PretestAction");
            // 
            // Pre_14
            // 
            Pre_14.Enabled = true;
            Pre_14.Name = "Pre_14";
            Pre_14.ResultSet = 1;
            Pre_14.RowCount = 3;
            // 
            // EmpNPPhSing_1Data
            // 
            this.EmpNPPhSing_1Data.PosttestAction = null;
            this.EmpNPPhSing_1Data.PretestAction = EmpNPPhSing_1_PretestAction;
            this.EmpNPPhSing_1Data.TestAction = EmpNPPhSing_1_TestAction;
            // 
            // StrNPPhSing_2Data
            // 
            this.StrNPPhSing_2Data.PosttestAction = null;
            this.StrNPPhSing_2Data.PretestAction = StrNPPhSing_2_PretestAction;
            this.StrNPPhSing_2Data.TestAction = StrNPPhSing_2_TestAction;
            // 
            // EmpPriWoAlFl_3Data
            // 
            this.EmpPriWoAlFl_3Data.PosttestAction = null;
            this.EmpPriWoAlFl_3Data.PretestAction = EmpPriWoAlFl_3_PretestAction;
            this.EmpPriWoAlFl_3Data.TestAction = EmpPriWoAlFl_3_TestAction;
            // 
            // StrPriWoAlFl_4Data
            // 
            this.StrPriWoAlFl_4Data.PosttestAction = null;
            this.StrPriWoAlFl_4Data.PretestAction = StrPriWoAlFl_4_PretestAction;
            this.StrPriWoAlFl_4Data.TestAction = StrPriWoAlFl_4_TestAction;
            // 
            // EmpPriWtAlPs_5Data
            // 
            this.EmpPriWtAlPs_5Data.PosttestAction = null;
            this.EmpPriWtAlPs_5Data.PretestAction = EmpPriWtAlPs_5_PretestAction;
            this.EmpPriWtAlPs_5Data.TestAction = EmpPriWtAlPs_5_TestAction;
            // 
            // StrPriWtAlPs_6Data
            // 
            this.StrPriWtAlPs_6Data.PosttestAction = null;
            this.StrPriWtAlPs_6Data.PretestAction = StrPriWtAlPs_6_PretestAction;
            this.StrPriWtAlPs_6Data.TestAction = StrPriWtAlPs_6_TestAction;
            // 
            // EmpOnPhFl_7Data
            // 
            this.EmpOnPhFl_7Data.PosttestAction = null;
            this.EmpOnPhFl_7Data.PretestAction = EmpOnPhFl_7_PretestAction;
            this.EmpOnPhFl_7Data.TestAction = EmpOnPhFl_7_TestAction;
            // 
            // StrOnPhFl_8Data
            // 
            this.StrOnPhFl_8Data.PosttestAction = null;
            this.StrOnPhFl_8Data.PretestAction = StrOnPhFl_8_PretestAction;
            this.StrOnPhFl_8Data.TestAction = StrOnPhFl_8_TestAction;
            // 
            // EmpMulPhRm_9Data
            // 
            this.EmpMulPhRm_9Data.PosttestAction = null;
            this.EmpMulPhRm_9Data.PretestAction = EmpMulPhRm_9_PretestAction;
            this.EmpMulPhRm_9Data.TestAction = EmpMulPhRm_9_TestAction;
            // 
            // StrMulPhRm_10Data
            // 
            this.StrMulPhRm_10Data.PosttestAction = null;
            this.StrMulPhRm_10Data.PretestAction = StrMulPhRm_10_PretestAction;
            this.StrMulPhRm_10Data.TestAction = StrMulPhRm_10_TestAction;
            // 
            // EmpDelAll_11Data
            // 
            this.EmpDelAll_11Data.PosttestAction = null;
            this.EmpDelAll_11Data.PretestAction = EmpDelAll_11_PretestAction;
            this.EmpDelAll_11Data.TestAction = EmpDelAll_11_TestAction;
            // 
            // StrDelAllFl_12Data
            // 
            this.StrDelAllFl_12Data.PosttestAction = null;
            this.StrDelAllFl_12Data.PretestAction = StrDelAllFl_12_PretestAction;
            this.StrDelAllFl_12Data.TestAction = StrDelAllFl_12_TestAction;
            // 
            // EmpPriWoPrFl_13Data
            // 
            this.EmpPriWoPrFl_13Data.PosttestAction = null;
            this.EmpPriWoPrFl_13Data.PretestAction = EmpPriWoPrFl_13_PretestAction;
            this.EmpPriWoPrFl_13Data.TestAction = EmpPriWoPrFl_13_TestAction;
            // 
            // StrPriWoPrFl_14Data
            // 
            this.StrPriWoPrFl_14Data.PosttestAction = null;
            this.StrPriWoPrFl_14Data.PretestAction = StrPriWoPrFl_14_PretestAction;
            this.StrPriWoPrFl_14Data.TestAction = StrPriWoPrFl_14_TestAction;
            // 
            // Test_1
            // 
            Test_1.ColumnNumber = 1;
            Test_1.Enabled = true;
            Test_1.ExpectedValue = "2";
            Test_1.Name = "Test_1";
            Test_1.NullExpected = false;
            Test_1.ResultSet = 1;
            Test_1.RowNumber = 1;
            // 
            // uspRemovePhoneNumber
            // 
            this.TestCleanupAction = testCleanupAction;
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
        public void EmpNPPhSing_1()
        {
            SqlDatabaseTestActions testActions = this.EmpNPPhSing_1Data;
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
        public void StrNPPhSing_2()
        {
            SqlDatabaseTestActions testActions = this.StrNPPhSing_2Data;
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
        [TestMethod(), ExpectedSqlException(MatchFirstError =false, MessageNumber =50001, Severity =19,State =1)]
        public void EmpPriWoAlFl_3()
        {
            SqlDatabaseTestActions testActions = this.EmpPriWoAlFl_3Data;
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
        [TestMethod(), ExpectedSqlException(MatchFirstError = false, MessageNumber = 50001, Severity = 19, State = 1)]
        public void StrPriWoAlFl_4()
        {
            SqlDatabaseTestActions testActions = this.StrPriWoAlFl_4Data;
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
        public void EmpPriWtAlPs_5()
        {
            SqlDatabaseTestActions testActions = this.EmpPriWtAlPs_5Data;
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
        public void StrPriWtAlPs_6()
        {
            SqlDatabaseTestActions testActions = this.StrPriWtAlPs_6Data;
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
        [TestMethod(), ExpectedSqlException(MatchFirstError = false, MessageNumber = 50001, Severity = 19, State = 1)]
        public void EmpOnPhFl_7()
        {
            SqlDatabaseTestActions testActions = this.EmpOnPhFl_7Data;
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
        [TestMethod(), ExpectedSqlException(MatchFirstError = false, MessageNumber = 50001, Severity = 19, State = 1)]
        public void StrOnPhFl_8()
        {
            SqlDatabaseTestActions testActions = this.StrOnPhFl_8Data;
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
        public void EmpMulPhRm_9()
        {
            SqlDatabaseTestActions testActions = this.EmpMulPhRm_9Data;
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
        public void StrMulPhRm_10()
        {
            SqlDatabaseTestActions testActions = this.StrMulPhRm_10Data;
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
        public void EmpDelAll_11()
        {
            SqlDatabaseTestActions testActions = this.EmpDelAll_11Data;
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
        [TestMethod(), ExpectedSqlException(MatchFirstError = false, MessageNumber = 50001, Severity = 19, State = 1)]
        public void StrDelAllFl_12()
        {
            SqlDatabaseTestActions testActions = this.StrDelAllFl_12Data;
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
        [TestMethod(), ExpectedSqlException(MatchFirstError = false, MessageNumber = 50001, Severity = 19, State = 1)]
        public void EmpPriWoPrFl_13()
        {
            SqlDatabaseTestActions testActions = this.EmpPriWoPrFl_13Data;
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
        [TestMethod(), ExpectedSqlException(MatchFirstError = false, MessageNumber = 50001, Severity = 19, State = 1)]
        public void StrPriWoPrFl_14()
        {
            SqlDatabaseTestActions testActions = this.StrPriWoPrFl_14Data;
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













        private SqlDatabaseTestActions EmpNPPhSing_1Data;
        private SqlDatabaseTestActions StrNPPhSing_2Data;
        private SqlDatabaseTestActions EmpPriWoAlFl_3Data;
        private SqlDatabaseTestActions StrPriWoAlFl_4Data;
        private SqlDatabaseTestActions EmpPriWtAlPs_5Data;
        private SqlDatabaseTestActions StrPriWtAlPs_6Data;
        private SqlDatabaseTestActions EmpOnPhFl_7Data;
        private SqlDatabaseTestActions StrOnPhFl_8Data;
        private SqlDatabaseTestActions EmpMulPhRm_9Data;
        private SqlDatabaseTestActions StrMulPhRm_10Data;
        private SqlDatabaseTestActions EmpDelAll_11Data;
        private SqlDatabaseTestActions StrDelAllFl_12Data;
        private SqlDatabaseTestActions EmpPriWoPrFl_13Data;
        private SqlDatabaseTestActions StrPriWoPrFl_14Data;
    }
}
