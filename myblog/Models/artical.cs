using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myblog.Models
{
    public class artical
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 摘要
        /// </summary>
        public string Abstra { get; set; }
        /// <summary>
        /// 文章标题
        /// </summary>
        public string Caption { get; set; }
        /// <summary>
        /// 发布日期
        /// </summary>
        public string PublishDate { get; set; }
        /// <summary>
        /// 最近修改日期
        /// </summary>
        public string LastEditDate { get; set; }
        /// <summary>
        /// 标签
        /// </summary>
        public Array Label { get; set; }
        /// <summary>
        /// 分类
        /// </summary>
        public Array Sort { get; set; }
    }
}