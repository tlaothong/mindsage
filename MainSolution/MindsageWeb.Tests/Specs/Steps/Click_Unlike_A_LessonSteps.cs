﻿using MindsageWeb.Repositories;
using MindsageWeb.Repositories.Models;
using Moq;
using Newtonsoft.Json;
using System;
using TechTalk.SpecFlow;

namespace MindsageWeb.Tests.Specs.Steps
{
    [Binding]
    public class Click_Unlike_A_LessonSteps
    {
        [Then(@"System update LikeLesson by JSON format is")]
        public void ThenSystemUpdateLikeLessonByJSONFormatIs(string multilineText)
        {
            var expected = JsonConvert.DeserializeObject<LikeLesson>(multilineText);
            var mockLikeLessonRepo = ScenarioContext.Current.Get<Moq.Mock<ILikeLessonRepository>>();
            mockLikeLessonRepo.Verify(it => it.UpsertLikeLesson(It.Is<LikeLesson>(ll =>
                ll.ClassRoomId == expected.ClassRoomId
                && ll.LessonId == expected.LessonId
                && ll.LikedByUserProfileId == expected.LikedByUserProfileId
                && ll.DeletedDate == expected.DeletedDate
            )));
        }
    }
}
