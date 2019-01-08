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
    public class uspRemoveEmployee : SqlDatabaseTestClass
    {

        public uspRemoveEmployee()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpDelRmRec_1_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uspRemoveEmployee));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition Test_1_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition Test_1_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition Test_1_3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testInitializeAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testCleanupAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpDelRmRec_1_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpMnAsOw_2_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition test_2_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition test_2_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition test_2_3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_2_4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpMnAsOw_2_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpMnAsAl_3_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition test_3_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition test_3_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition test_3_3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition test_3_4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpMnAsAl_3_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction DelOwnFl_4_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction DelAltNonMFl_5_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction DelAltNonMFl_5_PretestAction;
            this.EmpDelRmRec_1Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.EmpMnAsOw_2Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.EmpMnAsAl_3Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.DelOwnFl_4Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.DelAltNonMFl_5Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            EmpDelRmRec_1_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Test_1_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            Test_1_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            Test_1_3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            testInitializeAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            testCleanupAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            EmpDelRmRec_1_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            EmpMnAsOw_2_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            test_2_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            test_2_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            test_2_3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            test_2_4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            EmpMnAsOw_2_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            EmpMnAsAl_3_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            test_3_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            test_3_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            test_3_3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            test_3_4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            EmpMnAsAl_3_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            DelOwnFl_4_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            DelAltNonMFl_5_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            DelAltNonMFl_5_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            // 
            // EmpDelRmRec_1_TestAction
            // 
            EmpDelRmRec_1_TestAction.Conditions.Add(Test_1_1);
            EmpDelRmRec_1_TestAction.Conditions.Add(Test_1_2);
            EmpDelRmRec_1_TestAction.Conditions.Add(Test_1_3);
            resources.ApplyResources(EmpDelRmRec_1_TestAction, "EmpDelRmRec_1_TestAction");
            // 
            // Test_1_1
            // 
            Test_1_1.Enabled = true;
            Test_1_1.Name = "Test_1_1";
            Test_1_1.ResultSet = 1;
            // 
            // Test_1_2
            // 
            Test_1_2.Enabled = true;
            Test_1_2.Name = "Test_1_2";
            Test_1_2.ResultSet = 1;
            // 
            // Test_1_3
            // 
            Test_1_3.Enabled = true;
            Test_1_3.Name = "Test_1_3";
            Test_1_3.ResultSet = 3;
            // 
            // testInitializeAction
            // 
            resources.ApplyResources(testInitializeAction, "testInitializeAction");
            // 
            // testCleanupAction
            // 
            resources.ApplyResources(testCleanupAction, "testCleanupAction");
            // 
            // EmpDelRmRec_1_PretestAction
            // 
            resources.ApplyResources(EmpDelRmRec_1_PretestAction, "EmpDelRmRec_1_PretestAction");
            // 
            // EmpMnAsOw_2_TestAction
            // 
            EmpMnAsOw_2_TestAction.Conditions.Add(test_2_1);
            EmpMnAsOw_2_TestAction.Conditions.Add(test_2_2);
            EmpMnAsOw_2_TestAction.Conditions.Add(test_2_3);
            EmpMnAsOw_2_TestAction.Conditions.Add(test_2_4);
            resources.ApplyResources(EmpMnAsOw_2_TestAction, "EmpMnAsOw_2_TestAction");
            // 
            // test_2_1
            // 
            test_2_1.Enabled = true;
            test_2_1.Name = "test_2_1";
            test_2_1.ResultSet = 1;
            // 
            // test_2_2
            // 
            test_2_2.Enabled = true;
            test_2_2.Name = "test_2_2";
            test_2_2.ResultSet = 2;
            // 
            // test_2_3
            // 
            test_2_3.Enabled = true;
            test_2_3.Name = "test_2_3";
            test_2_3.ResultSet = 3;
            // 
            // test_2_4
            // 
            test_2_4.ColumnNumber = 1;
            test_2_4.Enabled = true;
            test_2_4.ExpectedValue = "true";
            test_2_4.Name = "test_2_4";
            test_2_4.NullExpected = false;
            test_2_4.ResultSet = 4;
            test_2_4.RowNumber = 1;
            // 
            // EmpMnAsOw_2_PretestAction
            // 
            resources.ApplyResources(EmpMnAsOw_2_PretestAction, "EmpMnAsOw_2_PretestAction");
            // 
            // EmpMnAsAl_3_TestAction
            // 
            EmpMnAsAl_3_TestAction.Conditions.Add(test_3_1);
            EmpMnAsAl_3_TestAction.Conditions.Add(test_3_2);
            EmpMnAsAl_3_TestAction.Conditions.Add(test_3_3);
            EmpMnAsAl_3_TestAction.Conditions.Add(test_3_4);
            resources.ApplyResources(EmpMnAsAl_3_TestAction, "EmpMnAsAl_3_TestAction");
            // 
            // test_3_1
            // 
            test_3_1.Enabled = true;
            test_3_1.Name = "test_3_1";
            test_3_1.ResultSet = 1;
            // 
            // test_3_2
            // 
            test_3_2.Enabled = true;
            test_3_2.Name = "test_3_2";
            test_3_2.ResultSet = 2;
            // 
            // test_3_3
            // 
            test_3_3.Enabled = true;
            test_3_3.Name = "test_3_3";
            test_3_3.ResultSet = 3;
            // 
            // test_3_4
            // 
            test_3_4.ColumnNumber = 1;
            test_3_4.Enabled = true;
            test_3_4.ExpectedValue = "true";
            test_3_4.Name = "test_3_4";
            test_3_4.NullExpected = false;
            test_3_4.ResultSet = 4;
            test_3_4.RowNumber = 1;
            // 
            // EmpMnAsAl_3_PretestAction
            // 
            resources.ApplyResources(EmpMnAsAl_3_PretestAction, "EmpMnAsAl_3_PretestAction");
            // 
            // DelOwnFl_4_TestAction
            // 
            resources.ApplyResources(DelOwnFl_4_TestAction, "DelOwnFl_4_TestAction");
            // 
            // DelAltNonMFl_5_TestAction
            // 
            resources.ApplyResources(DelAltNonMFl_5_TestAction, "DelAltNonMFl_5_TestAction");
            // 
            // DelAltNonMFl_5_PretestAction
            // 
            resources.ApplyResources(DelAltNonMFl_5_PretestAction, "DelAltNonMFl_5_PretestAction");
            // 
            // EmpDelRmRec_1Data
            // 
            this.EmpDelRmRec_1Data.PosttestAction = null;
            this.EmpDelRmRec_1Data.PretestAction = EmpDelRmRec_1_PretestAction;
            this.EmpDelRmRec_1Data.TestAction = EmpDelRmRec_1_TestAction;
            // 
            // EmpMnAsOw_2Data
            // 
            this.EmpMnAsOw_2Data.PosttestAction = null;
            this.EmpMnAsOw_2Data.PretestAction = EmpMnAsOw_2_PretestAction;
            this.EmpMnAsOw_2Data.TestAction = EmpMnAsOw_2_TestAction;
            // 
            // EmpMnAsAl_3Data
            // 
            this.EmpMnAsAl_3Data.PosttestAction = null;
            this.EmpMnAsAl_3Data.PretestAction = EmpMnAsAl_3_PretestAction;
            this.EmpMnAsAl_3Data.TestAction = EmpMnAsAl_3_TestAction;
            // 
            // DelOwnFl_4Data
            // 
            this.DelOwnFl_4Data.PosttestAction = null;
            this.DelOwnFl_4Data.PretestAction = null;
            this.DelOwnFl_4Data.TestAction = DelOwnFl_4_TestAction;
            // 
            // DelAltNonMFl_5Data
            // 
            this.DelAltNonMFl_5Data.PosttestAction = null;
            this.DelAltNonMFl_5Data.PretestAction = DelAltNonMFl_5_PretestAction;
            this.DelAltNonMFl_5Data.TestAction = DelAltNonMFl_5_TestAction;
            // 
            // uspRemoveEmployee
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
        public void EmpDelRmRec_1()
        {
            SqlDatabaseTestActions testActions = this.EmpDelRmRec_1Data;
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
        public void EmpMnAsOw_2()
        {
            SqlDatabaseTestActions testActions = this.EmpMnAsOw_2Data;
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
        public void EmpMnAsAl_3()
        {
            SqlDatabaseTestActions testActions = this.EmpMnAsAl_3Data;
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
        public void DelOwnFl_4()
        {
            SqlDatabaseTestActions testActions = this.DelOwnFl_4Data;
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
        public void DelAltNonMFl_5()
        {
            SqlDatabaseTestActions testActions = this.DelAltNonMFl_5Data;
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




        private SqlDatabaseTestActions EmpDelRmRec_1Data;
        private SqlDatabaseTestActions EmpMnAsOw_2Data;
        private SqlDatabaseTestActions EmpMnAsAl_3Data;
        private SqlDatabaseTestActions DelOwnFl_4Data;
        private SqlDatabaseTestActions DelAltNonMFl_5Data;
    }
}
