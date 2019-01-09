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
    public class uspAddEmployee : SqlDatabaseTestClass
    {

        public uspAddEmployee()
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
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AddEmpWithSinPh_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uspAddEmployee));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckCount;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction testCleanupAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AddEmpWithMulPh_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckCntMulPh;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AddEmpWithInvPh_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AddNonManagerWithPh_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckCountNonMan;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AddSenorLevelEmp_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition CheckCountSeniorLev;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AddJunRepSen_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition2;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AddEmpWithoutFnLn_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition3;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AddEmpWitInvMan_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition inconclusiveCondition4;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AddManWithStrRep_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction AddManWithStrRep_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition PreAddManWithStr;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition AddManWithStrT_1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition AddManWithStrt_2;
            this.AddEmpWithSinPhData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.AddEmpWithMulPhData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.AddEmpWithInvPhData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.AddNonManagerWithPhData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.AddSenorLevelEmpData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.AddJunRepSenData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.AddEmpWithoutFnLnData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.AddEmpWitInvManData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            this.AddManWithStrRepData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            AddEmpWithSinPh_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            CheckCount = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            testCleanupAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            AddEmpWithMulPh_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            CheckCntMulPh = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            AddEmpWithInvPh_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            AddNonManagerWithPh_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            CheckCountNonMan = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            AddSenorLevelEmp_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            CheckCountSeniorLev = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            AddJunRepSen_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            AddEmpWithoutFnLn_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition3 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            AddEmpWitInvMan_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            inconclusiveCondition4 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.InconclusiveCondition();
            AddManWithStrRep_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            AddManWithStrRep_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            PreAddManWithStr = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            AddManWithStrT_1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ScalarValueCondition();
            AddManWithStrt_2 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            // 
            // AddEmpWithSinPh_TestAction
            // 
            AddEmpWithSinPh_TestAction.Conditions.Add(CheckCount);
            resources.ApplyResources(AddEmpWithSinPh_TestAction, "AddEmpWithSinPh_TestAction");
            // 
            // CheckCount
            // 
            CheckCount.ColumnNumber = 1;
            CheckCount.Enabled = true;
            CheckCount.ExpectedValue = "1";
            CheckCount.Name = "CheckCount";
            CheckCount.NullExpected = false;
            CheckCount.ResultSet = 1;
            CheckCount.RowNumber = 1;
            // 
            // testCleanupAction
            // 
            resources.ApplyResources(testCleanupAction, "testCleanupAction");
            // 
            // AddEmpWithMulPh_TestAction
            // 
            AddEmpWithMulPh_TestAction.Conditions.Add(CheckCntMulPh);
            resources.ApplyResources(AddEmpWithMulPh_TestAction, "AddEmpWithMulPh_TestAction");
            // 
            // CheckCntMulPh
            // 
            CheckCntMulPh.ColumnNumber = 1;
            CheckCntMulPh.Enabled = true;
            CheckCntMulPh.ExpectedValue = "3";
            CheckCntMulPh.Name = "CheckCntMulPh";
            CheckCntMulPh.NullExpected = false;
            CheckCntMulPh.ResultSet = 1;
            CheckCntMulPh.RowNumber = 1;
            // 
            // AddEmpWithInvPh_TestAction
            // 
            AddEmpWithInvPh_TestAction.Conditions.Add(inconclusiveCondition1);
            resources.ApplyResources(AddEmpWithInvPh_TestAction, "AddEmpWithInvPh_TestAction");
            // 
            // inconclusiveCondition1
            // 
            inconclusiveCondition1.Enabled = true;
            inconclusiveCondition1.Name = "inconclusiveCondition1";
            // 
            // AddNonManagerWithPh_TestAction
            // 
            AddNonManagerWithPh_TestAction.Conditions.Add(CheckCountNonMan);
            resources.ApplyResources(AddNonManagerWithPh_TestAction, "AddNonManagerWithPh_TestAction");
            // 
            // CheckCountNonMan
            // 
            CheckCountNonMan.ColumnNumber = 1;
            CheckCountNonMan.Enabled = true;
            CheckCountNonMan.ExpectedValue = "2";
            CheckCountNonMan.Name = "CheckCountNonMan";
            CheckCountNonMan.NullExpected = false;
            CheckCountNonMan.ResultSet = 1;
            CheckCountNonMan.RowNumber = 1;
            // 
            // AddSenorLevelEmp_TestAction
            // 
            AddSenorLevelEmp_TestAction.Conditions.Add(CheckCountSeniorLev);
            resources.ApplyResources(AddSenorLevelEmp_TestAction, "AddSenorLevelEmp_TestAction");
            // 
            // CheckCountSeniorLev
            // 
            CheckCountSeniorLev.ColumnNumber = 1;
            CheckCountSeniorLev.Enabled = true;
            CheckCountSeniorLev.ExpectedValue = "4";
            CheckCountSeniorLev.Name = "CheckCountSeniorLev";
            CheckCountSeniorLev.NullExpected = false;
            CheckCountSeniorLev.ResultSet = 1;
            CheckCountSeniorLev.RowNumber = 1;
            // 
            // AddJunRepSen_TestAction
            // 
            AddJunRepSen_TestAction.Conditions.Add(inconclusiveCondition2);
            resources.ApplyResources(AddJunRepSen_TestAction, "AddJunRepSen_TestAction");
            // 
            // inconclusiveCondition2
            // 
            inconclusiveCondition2.Enabled = true;
            inconclusiveCondition2.Name = "inconclusiveCondition2";
            // 
            // AddEmpWithoutFnLn_TestAction
            // 
            AddEmpWithoutFnLn_TestAction.Conditions.Add(inconclusiveCondition3);
            resources.ApplyResources(AddEmpWithoutFnLn_TestAction, "AddEmpWithoutFnLn_TestAction");
            // 
            // inconclusiveCondition3
            // 
            inconclusiveCondition3.Enabled = true;
            inconclusiveCondition3.Name = "inconclusiveCondition3";
            // 
            // AddEmpWitInvMan_TestAction
            // 
            AddEmpWitInvMan_TestAction.Conditions.Add(inconclusiveCondition4);
            resources.ApplyResources(AddEmpWitInvMan_TestAction, "AddEmpWitInvMan_TestAction");
            // 
            // inconclusiveCondition4
            // 
            inconclusiveCondition4.Enabled = true;
            inconclusiveCondition4.Name = "inconclusiveCondition4";
            // 
            // AddEmpWithSinPhData
            // 
            this.AddEmpWithSinPhData.PosttestAction = null;
            this.AddEmpWithSinPhData.PretestAction = null;
            this.AddEmpWithSinPhData.TestAction = AddEmpWithSinPh_TestAction;
            // 
            // AddEmpWithMulPhData
            // 
            this.AddEmpWithMulPhData.PosttestAction = null;
            this.AddEmpWithMulPhData.PretestAction = null;
            this.AddEmpWithMulPhData.TestAction = AddEmpWithMulPh_TestAction;
            // 
            // AddEmpWithInvPhData
            // 
            this.AddEmpWithInvPhData.PosttestAction = null;
            this.AddEmpWithInvPhData.PretestAction = null;
            this.AddEmpWithInvPhData.TestAction = AddEmpWithInvPh_TestAction;
            // 
            // AddNonManagerWithPhData
            // 
            this.AddNonManagerWithPhData.PosttestAction = null;
            this.AddNonManagerWithPhData.PretestAction = null;
            this.AddNonManagerWithPhData.TestAction = AddNonManagerWithPh_TestAction;
            // 
            // AddSenorLevelEmpData
            // 
            this.AddSenorLevelEmpData.PosttestAction = null;
            this.AddSenorLevelEmpData.PretestAction = null;
            this.AddSenorLevelEmpData.TestAction = AddSenorLevelEmp_TestAction;
            // 
            // AddJunRepSenData
            // 
            this.AddJunRepSenData.PosttestAction = null;
            this.AddJunRepSenData.PretestAction = null;
            this.AddJunRepSenData.TestAction = AddJunRepSen_TestAction;
            // 
            // AddEmpWithoutFnLnData
            // 
            this.AddEmpWithoutFnLnData.PosttestAction = null;
            this.AddEmpWithoutFnLnData.PretestAction = null;
            this.AddEmpWithoutFnLnData.TestAction = AddEmpWithoutFnLn_TestAction;
            // 
            // AddEmpWitInvManData
            // 
            this.AddEmpWitInvManData.PosttestAction = null;
            this.AddEmpWitInvManData.PretestAction = null;
            this.AddEmpWitInvManData.TestAction = AddEmpWitInvMan_TestAction;
            // 
            // AddManWithStrRepData
            // 
            this.AddManWithStrRepData.PosttestAction = null;
            this.AddManWithStrRepData.PretestAction = AddManWithStrRep_PretestAction;
            this.AddManWithStrRepData.TestAction = AddManWithStrRep_TestAction;
            // 
            // AddManWithStrRep_TestAction
            // 
            AddManWithStrRep_TestAction.Conditions.Add(AddManWithStrT_1);
            AddManWithStrRep_TestAction.Conditions.Add(AddManWithStrt_2);
            resources.ApplyResources(AddManWithStrRep_TestAction, "AddManWithStrRep_TestAction");
            // 
            // AddManWithStrRep_PretestAction
            // 
            AddManWithStrRep_PretestAction.Conditions.Add(PreAddManWithStr);
            resources.ApplyResources(AddManWithStrRep_PretestAction, "AddManWithStrRep_PretestAction");
            // 
            // PreAddManWithStr
            // 
            PreAddManWithStr.Enabled = true;
            PreAddManWithStr.Name = "PreAddManWithStr";
            PreAddManWithStr.ResultSet = 1;
            PreAddManWithStr.RowCount = 2;
            // 
            // AddManWithStrT_1
            // 
            AddManWithStrT_1.ColumnNumber = 1;
            AddManWithStrT_1.Enabled = true;
            AddManWithStrT_1.ExpectedValue = "1";
            AddManWithStrT_1.Name = "AddManWithStrT_1";
            AddManWithStrT_1.NullExpected = false;
            AddManWithStrT_1.ResultSet = 1;
            AddManWithStrT_1.RowNumber = 1;
            // 
            // AddManWithStrt_2
            // 
            AddManWithStrt_2.Enabled = true;
            AddManWithStrt_2.Name = "AddManWithStrt_2";
            AddManWithStrt_2.ResultSet = 2;
            AddManWithStrt_2.RowCount = 2;
            // 
            // uspAddEmployee
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
        public void AddEmpWithSinPh()
        {
            SqlDatabaseTestActions testActions = this.AddEmpWithSinPhData;
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
        public void AddEmpWithMulPh()
        {
            SqlDatabaseTestActions testActions = this.AddEmpWithMulPhData;
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
        public void AddEmpWithInvPh()
        {
            SqlDatabaseTestActions testActions = this.AddEmpWithInvPhData;
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
        public void AddNonManagerWithPh()
        {
            SqlDatabaseTestActions testActions = this.AddNonManagerWithPhData;
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
        public void AddSenorLevelEmp()
        {
            SqlDatabaseTestActions testActions = this.AddSenorLevelEmpData;
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
        public void AddJunRepSen()
        {
            SqlDatabaseTestActions testActions = this.AddJunRepSenData;
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
        public void AddEmpWithoutFnLn()
        {
            SqlDatabaseTestActions testActions = this.AddEmpWithoutFnLnData;
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
        public void AddEmpWitInvMan()
        {
            SqlDatabaseTestActions testActions = this.AddEmpWitInvManData;
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
        public void AddManWithStrRep()
        {
            SqlDatabaseTestActions testActions = this.AddManWithStrRepData;
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








        private SqlDatabaseTestActions AddEmpWithSinPhData;
        private SqlDatabaseTestActions AddEmpWithMulPhData;
        private SqlDatabaseTestActions AddEmpWithInvPhData;
        private SqlDatabaseTestActions AddNonManagerWithPhData;
        private SqlDatabaseTestActions AddSenorLevelEmpData;
        private SqlDatabaseTestActions AddJunRepSenData;
        private SqlDatabaseTestActions AddEmpWithoutFnLnData;
        private SqlDatabaseTestActions AddEmpWitInvManData;
        private SqlDatabaseTestActions AddManWithStrRepData;
    }
}
