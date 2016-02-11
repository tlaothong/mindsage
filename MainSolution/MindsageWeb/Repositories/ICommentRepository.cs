﻿using MindsageWeb.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindsageWeb.Repositories
{
    /// <summary>
    /// มาตรฐานในการติดต่อกับ Comment
    /// </summary>
    public interface ICommentRepository
    {
        #region Methods

        /// <summary>
        /// ขอข้อมูล comment จากรหัส lesson และผู้สร้าง comment
        /// </summary>
        /// <param name="lessonId">รหัส lesson ที่ต้องการขอข้อมูล</param>
        /// <param name="creatorProfiles">รายชื่อผู้สร้าง comment ที่ต้องการ</param>
        IEnumerable<Comment> GetCommentsByLessonId(string lessonId, IEnumerable<string> creatorProfiles);

        #endregion Methods
    }
}