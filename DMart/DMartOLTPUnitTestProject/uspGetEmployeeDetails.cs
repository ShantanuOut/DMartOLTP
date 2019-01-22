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
    public class uspGetEmployeeDetails : SqlDatabaseTestClass
    {

        public uspGetEmployeeDetails()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AllEmpifNoEC_1_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uspGetEmployeeDetails));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_1_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_1_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_1_3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_1_4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_1_5;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_1_6;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_1_7;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testInitializeAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testCleanupAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction RetOneIfECNE_2_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction RetAllDet_3_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_3_1;
            this.AllEmpifNoEC_1Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.RetOneIfECNE_2Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.RetAllDet_3Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            AllEmpifNoEC_1_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Test_1_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Test_1_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Test_1_3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Test_1_4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Test_1_5 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Test_1_6 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Test_1_7 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            testInitializeAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            testCleanupAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            RetOneIfECNE_2_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Test_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            RetAllDet_3_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Test_3_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // AllEmpifNoEC_1_TestAction
            // 
            AllEmpifNoEC_1_TestAction.Conditions.Add(Test_1_1);
            AllEmpifNoEC_1_TestAction.Conditions.Add(Test_1_2);
            AllEmpifNoEC_1_TestAction.Conditions.Add(Test_1_3);
            AllEmpifNoEC_1_TestAction.Conditions.Add(Test_1_4);
            AllEmpifNoEC_1_TestAction.Conditions.Add(Test_1_5);
            AllEmpifNoEC_1_TestAction.Conditions.Add(Test_1_6);
            AllEmpifNoEC_1_TestAction.Conditions.Add(Test_1_7);
            resources.ApplyResources(AllEmpifNoEC_1_TestAction, "AllEmpifNoEC_1_TestAction");
            // 
            // Test_1_1
            // 
            Test_1_1.ColumnNumber = 1;
            Test_1_1.Enabled = true;
            Test_1_1.ExpectedValue = "0";
            Test_1_1.Name = "Test_1_1";
            Test_1_1.NullExpected = false;
            Test_1_1.ResultSet = 1;
            Test_1_1.RowNumber = 1;
            // 
            // Test_1_2
            // 
            Test_1_2.ColumnNumber = 1;
            Test_1_2.Enabled = true;
            Test_1_2.ExpectedValue = "MANFN1 MANLN1";
            Test_1_2.Name = "Test_1_2";
            Test_1_2.NullExpected = false;
            Test_1_2.ResultSet = 2;
            Test_1_2.RowNumber = 1;
            // 
            // Test_1_3
            // 
            Test_1_3.ColumnNumber = 2;
            Test_1_3.Enabled = true;
            Test_1_3.ExpectedValue = "MANFN";
            Test_1_3.Name = "Test_1_3";
            Test_1_3.NullExpected = false;
            Test_1_3.ResultSet = 2;
            Test_1_3.RowNumber = 1;
            // 
            // Test_1_4
            // 
            Test_1_4.ColumnNumber = 3;
            Test_1_4.Enabled = true;
            Test_1_4.ExpectedValue = "Manager";
            Test_1_4.Name = "Test_1_4";
            Test_1_4.NullExpected = false;
            Test_1_4.ResultSet = 2;
            Test_1_4.RowNumber = 1;
            // 
            // Test_1_5
            // 
            Test_1_5.ColumnNumber = 4;
            Test_1_5.Enabled = true;
            Test_1_5.ExpectedValue = "1";
            Test_1_5.Name = "Test_1_5";
            Test_1_5.NullExpected = false;
            Test_1_5.ResultSet = 2;
            Test_1_5.RowNumber = 1;
            // 
            // Test_1_6
            // 
            Test_1_6.ColumnNumber = 5;
            Test_1_6.Enabled = true;
            Test_1_6.ExpectedValue = "2";
            Test_1_6.Name = "Test_1_6";
            Test_1_6.NullExpected = false;
            Test_1_6.ResultSet = 2;
            Test_1_6.RowNumber = 1;
            // 
            // Test_1_7
            // 
            Test_1_7.ColumnNumber = 6;
            Test_1_7.Enabled = true;
            Test_1_7.ExpectedValue = "+918983879706";
            Test_1_7.Name = "Test_1_7";
            Test_1_7.NullExpected = false;
            Test_1_7.ResultSet = 2;
            Test_1_7.RowNumber = 1;
            // 
            // testInitializeAction
            // 
            resources.ApplyResources(testInitializeAction, "testInitializeAction");
            // 
            // testCleanupAction
            // 
            resources.ApplyResources(testCleanupAction, "testCleanupAction");
            // 
            // RetOneIfECNE_2_TestAction
            // 
            RetOneIfECNE_2_TestAction.Conditions.Add(Test_2);
            resources.ApplyResources(RetOneIfECNE_2_TestAction, "RetOneIfECNE_2_TestAction");
            // 
            // Test_2
            // 
            Test_2.ColumnNumber = 1;
            Test_2.Enabled = true;
            Test_2.ExpectedValue = "1";
            Test_2.Name = "Test_2";
            Test_2.NullExpected = false;
            Test_2.ResultSet = 1;
            Test_2.RowNumber = 1;
            // 
            // RetAllDet_3_TestAction
            // 
            RetAllDet_3_TestAction.Conditions.Add(Test_3_1);
            resources.ApplyResources(RetAllDet_3_TestAction, "RetAllDet_3_TestAction");
            // 
            // Test_3_1
            // 
            Test_3_1.ColumnNumber = 1;
            Test_3_1.Enabled = true;
            Test_3_1.ExpectedValue = "0";
            Test_3_1.Name = "Test_3_1";
            Test_3_1.NullExpected = false;
            Test_3_1.ResultSet = 1;
            Test_3_1.RowNumber = 1;
            // 
            // AllEmpifNoEC_1Data
            // 
            this.AllEmpifNoEC_1Data.PosttestAction = null;
            this.AllEmpifNoEC_1Data.PretestAction = null;
            this.AllEmpifNoEC_1Data.TestAction = AllEmpifNoEC_1_TestAction;
            // 
            // RetOneIfECNE_2Data
            // 
            this.RetOneIfECNE_2Data.PosttestAction = null;
            this.RetOneIfECNE_2Data.PretestAction = null;
            this.RetOneIfECNE_2Data.TestAction = RetOneIfECNE_2_TestAction;
            // 
            // RetAllDet_3Data
            // 
            this.RetAllDet_3Data.PosttestAction = null;
            this.RetAllDet_3Data.PretestAction = null;
            this.RetAllDet_3Data.TestAction = RetAllDet_3_TestAction;
            // 
            // uspGetEmployeeDetails
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
        public void AllEmpifNoEC_1()
        {
            SqlDatabaseTestActions testActions = this.AllEmpifNoEC_1Data;
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
        public void RetOneIfECNE_2()
        {
            SqlDatabaseTestActions testActions = this.RetOneIfECNE_2Data;
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
        public void RetAllDet_3()
        {
            SqlDatabaseTestActions testActions = this.RetAllDet_3Data;
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


        private SqlDatabaseTestActions AllEmpifNoEC_1Data;
        private SqlDatabaseTestActions RetOneIfECNE_2Data;
        private SqlDatabaseTestActions RetAllDet_3Data;
    }
}
