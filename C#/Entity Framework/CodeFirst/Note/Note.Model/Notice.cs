﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Note.Model
{
    /*
     * [Key] : Primary Key
     * [Required] : Not null
     */
    /// <summary>
    /// 공지사항
    /// </summary>
    public class Notice
    {
        /// <summary>
        /// 공지사항
        /// </summary>
        [Key]
        public int NoticeNo { get; set; }
        /// <summary>
        /// 공지사항 제목
        /// </summary>
        [Required]  
        public string NoticeTitle { get; set; }
        /// <summary>
        /// 공지사항 내용
        /// </summary>
        [Required]  
        public string NoticeContents { get; set; }
        /// <summary>
        /// 공지사항 작성날짜
        /// </summary>
        [Required]  
        public DateTime NoticeWriteDate{ get; set; }
        /// <summary>
        /// 공지사항 조회수
        /// </summary>
        public int NoticeViewCount { get; set; }

    }
}
