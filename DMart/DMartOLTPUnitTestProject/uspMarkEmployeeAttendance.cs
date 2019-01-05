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
    public class uspMarkEmployeeAttendance : SqlDatabaseTestClass
    {

        public uspMarkEmployeeAttendance()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction InsEmpAtt_1_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uspMarkEmployeeAttendance));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_1_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Test_2_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction InsEmpAtt_1_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction InsEmpAtt_1_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction DupEmpAtt_2_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction DupEmpAtt_2_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Pre_2_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition Pre_2_2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction DupEmpAtt_2_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction InvEmpCodAtt_3_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition Test_3_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition Test_3_2;
            this.InsEmpAtt_1Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.DupEmpAtt_2Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.InvEmpCodAtt_3Data = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            InsEmpAtt_1_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Test_1_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Test_2_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            InsEmpAtt_1_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            InsEmpAtt_1_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            DupEmpAtt_2_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            DupEmpAtt_2_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Pre_2_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Pre_2_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            DupEmpAtt_2_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            InvEmpCodAtt_3_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            Test_3_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            Test_3_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.EmptyResultSetCondition();
            // 
            // InsEmpAtt_1_TestAction
            // 
            InsEmpAtt_1_TestAction.Conditions.Add(Test_1_1);
            InsEmpAtt_1_TestAction.Conditions.Add(Test_2_1);
            resources.ApplyResources(InsEmpAtt_1_TestAction, "InsEmpAtt_1_TestAction");
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
            // Test_2_1
            // 
            Test_2_1.Enabled = true;
            Test_2_1.Name = "Test_2_1";
            Test_2_1.ResultSet = 2;
            Test_2_1.RowCount = 1;
            // 
            // InsEmpAtt_1_PretestAction
            // 
            resources.ApplyResources(InsEmpAtt_1_PretestAction, "InsEmpAtt_1_PretestAction");
            // 
            // InsEmpAtt_1_PosttestAction
            // 
            resources.ApplyResources(InsEmpAtt_1_PosttestAction, "InsEmpAtt_1_PosttestAction");
            // 
            // DupEmpAtt_2_TestAction
            // 
            resources.ApplyResources(DupEmpAtt_2_TestAction, "DupEmpAtt_2_TestAction");
            // 
            // DupEmpAtt_2_PretestAction
            // 
            DupEmpAtt_2_PretestAction.Conditions.Add(Pre_2_1);
            DupEmpAtt_2_PretestAction.Conditions.Add(Pre_2_2);
            resources.ApplyResources(DupEmpAtt_2_PretestAction, "DupEmpAtt_2_PretestAction");
            // 
            // Pre_2_1
            // 
            Pre_2_1.ColumnNumber = 1;
            Pre_2_1.Enabled = true;
            Pre_2_1.ExpectedValue = "0";
            Pre_2_1.Name = "Pre_2_1";
            Pre_2_1.NullExpected = false;
            Pre_2_1.ResultSet = 1;
            Pre_2_1.RowNumber = 1;
            // 
            // Pre_2_2
            // 
            Pre_2_2.Enabled = true;
            Pre_2_2.Name = "Pre_2_2";
            Pre_2_2.ResultSet = 2;
            Pre_2_2.RowCount = 1;
            // 
            // DupEmpAtt_2_PosttestAction
            // 
            resources.ApplyResources(DupEmpAtt_2_PosttestAction, "DupEmpAtt_2_PosttestAction");
            // 
            // InsEmpAtt_1Data
            // 
            this.InsEmpAtt_1Data.PosttestAction = InsEmpAtt_1_PosttestAction;
            this.InsEmpAtt_1Data.PretestAction = InsEmpAtt_1_PretestAction;
            this.InsEmpAtt_1Data.TestAction = InsEmpAtt_1_TestAction;
            // 
            // DupEmpAtt_2Data
            // 
            this.DupEmpAtt_2Data.PosttestAction = DupEmpAtt_2_PosttestAction;
            this.DupEmpAtt_2Data.PretestAction = DupEmpAtt_2_PretestAction;
            this.DupEmpAtt_2Data.TestAction = DupEmpAtt_2_TestAction;
            // 
            // InvEmpCodAtt_3Data
            // 
            this.InvEmpCodAtt_3Data.PosttestAction = null;
            this.InvEmpCodAtt_3Data.PretestAction = null;
            this.InvEmpCodAtt_3Data.TestAction = InvEmpCodAtt_3_TestAction;
            // 
            // InvEmpCodAtt_3_TestAction
            // 
            InvEmpCodAtt_3_TestAction.Conditions.Add(Test_3_1);
            InvEmpCodAtt_3_TestAction.Conditions.Add(Test_3_2);
            resources.ApplyResources(InvEmpCodAtt_3_TestAction, "InvEmpCodAtt_3_TestAction");
            // 
            // Test_3_1
            // 
            Test_3_1.ColumnNumber = 1;
            Test_3_1.Enabled = true;
            Test_3_1.ExpectedValue = "1";
            Test_3_1.Name = "Test_3_1";
            Test_3_1.NullExpected = false;
            Test_3_1.ResultSet = 1;
            Test_3_1.RowNumber = 1;
            // 
            // Test_3_2
            // 
            Test_3_2.Enabled = true;
            Test_3_2.Name = "Test_3_2";
            Test_3_2.ResultSet = 2;
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
        public void InsEmpAtt_1()
        {
            SqlDatabaseTestActions testActions = this.InsEmpAtt_1Data;
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
        public void DupEmpAtt_2()
        {
            SqlDatabaseTestActions testActions = this.DupEmpAtt_2Data;
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
        public void InvEmpCodAtt_3()
        {
            SqlDatabaseTestActions testActions = this.InvEmpCodAtt_3Data;
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


        private SqlDatabaseTestActions InsEmpAtt_1Data;
        private SqlDatabaseTestActions DupEmpAtt_2Data;
        private SqlDatabaseTestActions InvEmpCodAtt_3Data;
    }
}
