﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MindsageWeb.Tests.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class Show_Lesson_ContentFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Show_Lesson_Content.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Show_Lesson_Content", "\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the sum o" +
                    "f two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Show_Lesson_Content")))
            {
                MindsageWeb.Tests.Specs.Show_Lesson_ContentFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
 testRunner.Given("Initialize mocking data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
    testRunner.And("System have ClassRoom collection with JSON format are", @"[
    {
        ""id"": ""ClassRoom01"",
        ""Name"": ""Emotional literacy"",
        ""CourseCatalogId"": ""CourseCatalog01"",
        ""CreatedDate"": ""2/1/2016"",
        ""CourseMessage"": ""Don't forget to comment a lesson!"",
        ""Lessons"":
        [
            {
                ""id"": ""Lesson01"",
                ""TotalLikes"": 0,
                ""LessonCatalogId"": ""LessonCatalog01""
            },
            {
                ""id"": ""Lesson02"",
                ""TotalLikes"": 5,
                ""LessonCatalogId"": ""LessonCatalog02""
            },
            {
                ""id"": ""Lesson03"",
                ""TotalLikes"": 0,
                ""LessonCatalogId"": ""LessonCatalog03""
            },
        ]
    }
]", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
    testRunner.And("System have LessonCatalog collection with JSON format are", @"[
    {
        ""id"": ""LessonCatalog01"",
        ""Title"": ""What Is Emotional Literacy?"",
        ""ShortTeacherLessonPlan"": ""short teacher lesson plan01"",
        ""FullTeacherLessonPlan"": ""full teacher lesson plan01""
    },
    {
        ""id"": ""LessonCatalog02"",
        ""Title"": ""Intrinsic Education vs. Associative Learning"",
        ""ShortTeacherLessonPlan"": ""short teacher lesson plan02"",
        ""FullTeacherLessonPlan"": ""full teacher lesson plan02""
    },
    {
        ""id"": ""LessonCatalog03"",
        ""Title"": ""Three: What Is Goodness?"",
        ""ShortTeacherLessonPlan"": ""short teacher lesson plan03"",
        ""FullTeacherLessonPlan"": ""full teacher lesson plan03""
    },
]", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
    testRunner.And("System have ClassCalendar collection with JSON format are", @"[
    {
        ""id"": ""ClassCalendar01"",
        ""BeginDate"": ""2/1/2016"",
        ""ClassRoomId"": ""ClassRoom01"",
        ""LessonCalendars"":
        [
            {
                ""Id"": ""LessonCalendar01"",
                ""LessonId"": ""Lesson01"",
                ""BeginDate"": ""2/1/2016"",
                ""LessonCatalogId"": ""LessonCatalog01""
            },
            {
                ""Id"": ""LessonCalendar02"",
                ""LessonId"": ""Lesson02"",
                ""BeginDate"": ""2/8/2016"",
                ""LessonCatalogId"": ""LessonCatalog02""
            },
            {
                ""Id"": ""LessonCalendar03"",
                ""LessonId"": ""Lesson03"",
                ""BeginDate"": ""2/15/2016"",
                ""LessonCatalogId"": ""LessonCatalog03""
            },
        ]
    },
]", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 92
    testRunner.And("System have Subscription collection with JSON format are", "[\r\n    {\r\n        \"id\": \"Subscription01\",\r\n        \"UserProfileId\": \"sakul@mindsa" +
                    "ge.com\",\r\n        \"ClassRoomId\": \"ClassRoom01\",\r\n        \"Role\": \"Teacher\"\r\n    " +
                    "},\r\n]", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("User open a course\'s lesson Then system send the selected lesson\'s content back")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Show_Lesson_Content")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mock")]
        public virtual void UserOpenACourseSLessonThenSystemSendTheSelectedLessonSContentBack()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User open a course\'s lesson Then system send the selected lesson\'s content back", new string[] {
                        "mock"});
#line 105
this.ScenarioSetup(scenarioInfo);
#line 6
this.FeatureBackground();
#line 106
    testRunner.Given("Today is \'2/8/2016 00:00 am\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 107
    testRunner.When("UserProfile \'sakul@mindsage.com\' open the lesson \'Lesson02\' of ClassRoom: \'ClassR" +
                    "oom01\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 108
    testRunner.Then("System send lesson\'s content with JSON format is", @"{
    ""id"": ""Lesson02"",
    ""Title"": ""Intrinsic Education vs. Associative Learning"",
    ""ShortTeacherLessonPlan"": ""short teacher lesson plan02"",
    ""FullTeacherLessonPlan"": ""full teacher lesson plan02"",
    ""CourseMessage"": ""Don't forget to comment a lesson!"",
    ""TotalLikes"": 5,
    ""IsTeacher"": true
}", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
