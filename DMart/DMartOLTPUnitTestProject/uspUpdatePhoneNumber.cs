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
    public class uspUpdatePhoneNumber : SqlDatabaseTestClass
    {

        public uspUpdatePhoneNumber()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpSingNonPUpd_1_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uspUpdatePhoneNumber));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_1_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition Test_1_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testInitializeAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Init_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Init_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testCleanupAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StrSingNonPUpd_2_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_2_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition Test_2_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpMulNonPUpd_3_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_3_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_3_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition Test_3_3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StrMulNonPUpd_4_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_4_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_4_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition Test_4_3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpPriPhUpd_5_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_5_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition Test_5_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StrPriPhUpd_6_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_6_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition Test_6_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpInvPhUpdFl_7_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StrInvPhUpdFl_8_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpUpdNoTgPhFl_9_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction StrUpdNoTgPhFl_10_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction EmpChgPriNu_11_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_11_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_11_2;
            this.EmpSingNonPUpd_1Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StrSingNonPUpd_2Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.EmpMulNonPUpd_3Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StrMulNonPUpd_4Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.EmpPriPhUpd_5Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StrPriPhUpd_6Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.EmpInvPhUpdFl_7Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StrInvPhUpdFl_8Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.EmpUpdNoTgPhFl_9Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.StrUpdNoTgPhFl_10Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.EmpChgPriNu_11Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            EmpSingNonPUpd_1_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Test_1_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Test_1_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            testInitializeAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Init_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            Init_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            testCleanupAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            StrSingNonPUpd_2_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Test_2_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Test_2_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            EmpMulNonPUpd_3_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Test_3_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Test_3_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Test_3_3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            StrMulNonPUpd_4_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Test_4_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Test_4_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Test_4_3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            EmpPriPhUpd_5_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Test_5_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Test_5_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            StrPriPhUpd_6_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Test_6_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Test_6_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            EmpInvPhUpdFl_7_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            StrInvPhUpdFl_8_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            EmpUpdNoTgPhFl_9_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            StrUpdNoTgPhFl_10_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            EmpChgPriNu_11_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Test_11_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Test_11_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            // 
            // EmpSingNonPUpd_1_TestAction
            // 
            EmpSingNonPUpd_1_TestAction.Conditions.Add(Test_1_1);
            EmpSingNonPUpd_1_TestAction.Conditions.Add(Test_1_2);
            resources.ApplyResources(EmpSingNonPUpd_1_TestAction, "EmpSingNonPUpd_1_TestAction");
            // 
            // Test_1_1
            // 
            Test_1_1.ColumnNumber = 1;
            Test_1_1.Enabled = true;
            Test_1_1.ExpectedValue = "9998887776";
            Test_1_1.Name = "Test_1_1";
            Test_1_1.NullExpected = false;
            Test_1_1.ResultSet = 1;
            Test_1_1.RowNumber = 1;
            // 
            // Test_1_2
            // 
            Test_1_2.Enabled = true;
            Test_1_2.Name = "Test_1_2";
            Test_1_2.ResultSet = 2;
            // 
            // testInitializeAction
            // 
            testInitializeAction.Conditions.Add(Init_1);
            testInitializeAction.Conditions.Add(Init_2);
            resources.ApplyResources(testInitializeAction, "testInitializeAction");
            // 
            // Init_1
            // 
            Init_1.Enabled = true;
            Init_1.Name = "Init_1";
            Init_1.ResultSet = 1;
            Init_1.RowCount = 3;
            // 
            // Init_2
            // 
            Init_2.Enabled = true;
            Init_2.Name = "Init_2";
            Init_2.ResultSet = 2;
            Init_2.RowCount = 3;
            // 
            // testCleanupAction
            // 
            resources.ApplyResources(testCleanupAction, "testCleanupAction");
            // 
            // StrSingNonPUpd_2_TestAction
            // 
            StrSingNonPUpd_2_TestAction.Conditions.Add(Test_2_1);
            StrSingNonPUpd_2_TestAction.Conditions.Add(Test_2_2);
            resources.ApplyResources(StrSingNonPUpd_2_TestAction, "StrSingNonPUpd_2_TestAction");
            // 
            // Test_2_1
            // 
            Test_2_1.ColumnNumber = 1;
            Test_2_1.Enabled = true;
            Test_2_1.ExpectedValue = "9998887776";
            Test_2_1.Name = "Test_2_1";
            Test_2_1.NullExpected = false;
            Test_2_1.ResultSet = 1;
            Test_2_1.RowNumber = 1;
            // 
            // Test_2_2
            // 
            Test_2_2.Enabled = true;
            Test_2_2.Name = "Test_2_2";
            Test_2_2.ResultSet = 2;
            // 
            // EmpMulNonPUpd_3_TestAction
            // 
            EmpMulNonPUpd_3_TestAction.Conditions.Add(Test_3_1);
            EmpMulNonPUpd_3_TestAction.Conditions.Add(Test_3_2);
            EmpMulNonPUpd_3_TestAction.Conditions.Add(Test_3_3);
            resources.ApplyResources(EmpMulNonPUpd_3_TestAction, "EmpMulNonPUpd_3_TestAction");
            // 
            // Test_3_1
            // 
            Test_3_1.ColumnNumber = 1;
            Test_3_1.Enabled = true;
            Test_3_1.ExpectedValue = "9998887776";
            Test_3_1.Name = "Test_3_1";
            Test_3_1.NullExpected = false;
            Test_3_1.ResultSet = 1;
            Test_3_1.RowNumber = 1;
            // 
            // Test_3_2
            // 
            Test_3_2.ColumnNumber = 1;
            Test_3_2.Enabled = true;
            Test_3_2.ExpectedValue = "9998887777";
            Test_3_2.Name = "Test_3_2";
            Test_3_2.NullExpected = false;
            Test_3_2.ResultSet = 1;
            Test_3_2.RowNumber = 2;
            // 
            // Test_3_3
            // 
            Test_3_3.Enabled = true;
            Test_3_3.Name = "Test_3_3";
            Test_3_3.ResultSet = 2;
            // 
            // StrMulNonPUpd_4_TestAction
            // 
            StrMulNonPUpd_4_TestAction.Conditions.Add(Test_4_1);
            StrMulNonPUpd_4_TestAction.Conditions.Add(Test_4_2);
            StrMulNonPUpd_4_TestAction.Conditions.Add(Test_4_3);
            resources.ApplyResources(StrMulNonPUpd_4_TestAction, "StrMulNonPUpd_4_TestAction");
            // 
            // Test_4_1
            // 
            Test_4_1.ColumnNumber = 1;
            Test_4_1.Enabled = true;
            Test_4_1.ExpectedValue = "9998887776";
            Test_4_1.Name = "Test_4_1";
            Test_4_1.NullExpected = false;
            Test_4_1.ResultSet = 1;
            Test_4_1.RowNumber = 1;
            // 
            // Test_4_2
            // 
            Test_4_2.ColumnNumber = 1;
            Test_4_2.Enabled = true;
            Test_4_2.ExpectedValue = "9998887777";
            Test_4_2.Name = "Test_4_2";
            Test_4_2.NullExpected = false;
            Test_4_2.ResultSet = 1;
            Test_4_2.RowNumber = 2;
            // 
            // Test_4_3
            // 
            Test_4_3.Enabled = true;
            Test_4_3.Name = "Test_4_3";
            Test_4_3.ResultSet = 2;
            // 
            // EmpPriPhUpd_5_TestAction
            // 
            EmpPriPhUpd_5_TestAction.Conditions.Add(Test_5_1);
            EmpPriPhUpd_5_TestAction.Conditions.Add(Test_5_2);
            resources.ApplyResources(EmpPriPhUpd_5_TestAction, "EmpPriPhUpd_5_TestAction");
            // 
            // Test_5_1
            // 
            Test_5_1.ColumnNumber = 1;
            Test_5_1.Enabled = true;
            Test_5_1.ExpectedValue = "9998887776";
            Test_5_1.Name = "Test_5_1";
            Test_5_1.NullExpected = false;
            Test_5_1.ResultSet = 1;
            Test_5_1.RowNumber = 1;
            // 
            // Test_5_2
            // 
            Test_5_2.Enabled = true;
            Test_5_2.Name = "Test_5_2";
            Test_5_2.ResultSet = 2;
            // 
            // StrPriPhUpd_6_TestAction
            // 
            StrPriPhUpd_6_TestAction.Conditions.Add(Test_6_1);
            StrPriPhUpd_6_TestAction.Conditions.Add(Test_6_2);
            resources.ApplyResources(StrPriPhUpd_6_TestAction, "StrPriPhUpd_6_TestAction");
            // 
            // Test_6_1
            // 
            Test_6_1.ColumnNumber = 1;
            Test_6_1.Enabled = true;
            Test_6_1.ExpectedValue = "9998887776";
            Test_6_1.Name = "Test_6_1";
            Test_6_1.NullExpected = false;
            Test_6_1.ResultSet = 1;
            Test_6_1.RowNumber = 1;
            // 
            // Test_6_2
            // 
            Test_6_2.Enabled = true;
            Test_6_2.Name = "Test_6_2";
            Test_6_2.ResultSet = 1;
            // 
            // EmpInvPhUpdFl_7_TestAction
            // 
            resources.ApplyResources(EmpInvPhUpdFl_7_TestAction, "EmpInvPhUpdFl_7_TestAction");
            // 
            // StrInvPhUpdFl_8_TestAction
            // 
            resources.ApplyResources(StrInvPhUpdFl_8_TestAction, "StrInvPhUpdFl_8_TestAction");
            // 
            // EmpUpdNoTgPhFl_9_TestAction
            // 
            resources.ApplyResources(EmpUpdNoTgPhFl_9_TestAction, "EmpUpdNoTgPhFl_9_TestAction");
            // 
            // StrUpdNoTgPhFl_10_TestAction
            // 
            resources.ApplyResources(StrUpdNoTgPhFl_10_TestAction, "StrUpdNoTgPhFl_10_TestAction");
            // 
            // EmpSingNonPUpd_1Data
            // 
            this.EmpSingNonPUpd_1Data.PosttestAction = null;
            this.EmpSingNonPUpd_1Data.PretestAction = null;
            this.EmpSingNonPUpd_1Data.TestAction = EmpSingNonPUpd_1_TestAction;
            // 
            // StrSingNonPUpd_2Data
            // 
            this.StrSingNonPUpd_2Data.PosttestAction = null;
            this.StrSingNonPUpd_2Data.PretestAction = null;
            this.StrSingNonPUpd_2Data.TestAction = StrSingNonPUpd_2_TestAction;
            // 
            // EmpMulNonPUpd_3Data
            // 
            this.EmpMulNonPUpd_3Data.PosttestAction = null;
            this.EmpMulNonPUpd_3Data.PretestAction = null;
            this.EmpMulNonPUpd_3Data.TestAction = EmpMulNonPUpd_3_TestAction;
            // 
            // StrMulNonPUpd_4Data
            // 
            this.StrMulNonPUpd_4Data.PosttestAction = null;
            this.StrMulNonPUpd_4Data.PretestAction = null;
            this.StrMulNonPUpd_4Data.TestAction = StrMulNonPUpd_4_TestAction;
            // 
            // EmpPriPhUpd_5Data
            // 
            this.EmpPriPhUpd_5Data.PosttestAction = null;
            this.EmpPriPhUpd_5Data.PretestAction = null;
            this.EmpPriPhUpd_5Data.TestAction = EmpPriPhUpd_5_TestAction;
            // 
            // StrPriPhUpd_6Data
            // 
            this.StrPriPhUpd_6Data.PosttestAction = null;
            this.StrPriPhUpd_6Data.PretestAction = null;
            this.StrPriPhUpd_6Data.TestAction = StrPriPhUpd_6_TestAction;
            // 
            // EmpInvPhUpdFl_7Data
            // 
            this.EmpInvPhUpdFl_7Data.PosttestAction = null;
            this.EmpInvPhUpdFl_7Data.PretestAction = null;
            this.EmpInvPhUpdFl_7Data.TestAction = EmpInvPhUpdFl_7_TestAction;
            // 
            // StrInvPhUpdFl_8Data
            // 
            this.StrInvPhUpdFl_8Data.PosttestAction = null;
            this.StrInvPhUpdFl_8Data.PretestAction = null;
            this.StrInvPhUpdFl_8Data.TestAction = StrInvPhUpdFl_8_TestAction;
            // 
            // EmpUpdNoTgPhFl_9Data
            // 
            this.EmpUpdNoTgPhFl_9Data.PosttestAction = null;
            this.EmpUpdNoTgPhFl_9Data.PretestAction = null;
            this.EmpUpdNoTgPhFl_9Data.TestAction = EmpUpdNoTgPhFl_9_TestAction;
            // 
            // StrUpdNoTgPhFl_10Data
            // 
            this.StrUpdNoTgPhFl_10Data.PosttestAction = null;
            this.StrUpdNoTgPhFl_10Data.PretestAction = null;
            this.StrUpdNoTgPhFl_10Data.TestAction = StrUpdNoTgPhFl_10_TestAction;
            // 
            // EmpChgPriNu_11Data
            // 
            this.EmpChgPriNu_11Data.PosttestAction = null;
            this.EmpChgPriNu_11Data.PretestAction = null;
            this.EmpChgPriNu_11Data.TestAction = EmpChgPriNu_11_TestAction;
            // 
            // EmpChgPriNu_11_TestAction
            // 
            EmpChgPriNu_11_TestAction.Conditions.Add(Test_11_1);
            EmpChgPriNu_11_TestAction.Conditions.Add(Test_11_2);
            resources.ApplyResources(EmpChgPriNu_11_TestAction, "EmpChgPriNu_11_TestAction");
            // 
            // Test_11_1
            // 
            Test_11_1.ColumnNumber = 1;
            Test_11_1.Enabled = true;
            Test_11_1.ExpectedValue = "1";
            Test_11_1.Name = "Test_11_1";
            Test_11_1.NullExpected = false;
            Test_11_1.ResultSet = 1;
            Test_11_1.RowNumber = 1;
            // 
            // Test_11_2
            // 
            Test_11_2.ColumnNumber = 1;
            Test_11_2.Enabled = true;
            Test_11_2.ExpectedValue = "2";
            Test_11_2.Name = "Test_11_2";
            Test_11_2.NullExpected = false;
            Test_11_2.ResultSet = 2;
            Test_11_2.RowNumber = 1;
            // 
            // uspUpdatePhoneNumber
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
        public void EmpSingNonPUpd_1()
        {
            SqlDatabaseTestActions testActions = this.EmpSingNonPUpd_1Data;
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
        public void StrSingNonPUpd_2()
        {
            SqlDatabaseTestActions testActions = this.StrSingNonPUpd_2Data;
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
        public void EmpMulNonPUpd_3()
        {
            SqlDatabaseTestActions testActions = this.EmpMulNonPUpd_3Data;
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
        public void StrMulNonPUpd_4()
        {
            SqlDatabaseTestActions testActions = this.StrMulNonPUpd_4Data;
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
        public void EmpPriPhUpd_5()
        {
            SqlDatabaseTestActions testActions = this.EmpPriPhUpd_5Data;
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
        public void StrPriPhUpd_6()
        {
            SqlDatabaseTestActions testActions = this.StrPriPhUpd_6Data;
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
        [TestMethod(), ExpectedSqlException(MatchFirstError =false, MessageNumber = 50001, Severity =19, State =1)]
        public void EmpInvPhUpdFl_7()
        {
            SqlDatabaseTestActions testActions = this.EmpInvPhUpdFl_7Data;
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
        public void StrInvPhUpdFl_8()
        {
            SqlDatabaseTestActions testActions = this.StrInvPhUpdFl_8Data;
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
        public void EmpUpdNoTgPhFl_9()
        {
            SqlDatabaseTestActions testActions = this.EmpUpdNoTgPhFl_9Data;
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
        public void StrUpdNoTgPhFl_10()
        {
            SqlDatabaseTestActions testActions = this.StrUpdNoTgPhFl_10Data;
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
        public void EmpChgPriNu_11()
        {
            SqlDatabaseTestActions testActions = this.EmpChgPriNu_11Data;
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










        private SqlDatabaseTestActions EmpSingNonPUpd_1Data;
        private SqlDatabaseTestActions StrSingNonPUpd_2Data;
        private SqlDatabaseTestActions EmpMulNonPUpd_3Data;
        private SqlDatabaseTestActions StrMulNonPUpd_4Data;
        private SqlDatabaseTestActions EmpPriPhUpd_5Data;
        private SqlDatabaseTestActions StrPriPhUpd_6Data;
        private SqlDatabaseTestActions EmpInvPhUpdFl_7Data;
        private SqlDatabaseTestActions StrInvPhUpdFl_8Data;
        private SqlDatabaseTestActions EmpUpdNoTgPhFl_9Data;
        private SqlDatabaseTestActions StrUpdNoTgPhFl_10Data;
        private SqlDatabaseTestActions EmpChgPriNu_11Data;
    }
}
