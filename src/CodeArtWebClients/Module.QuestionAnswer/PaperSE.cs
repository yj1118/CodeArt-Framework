﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodeArt.DTO;
using CodeArt.Web.WebPages.Xaml.Script;


namespace Module.QuestionAnswer
{
    public class PaperSE : ScriptElement
    {
        /// <summary>
        /// 使用的试卷原型的编号
        /// </summary>
        public string PaperMetadataId
        {
            get
            {
                return this.Metadata.GetValue<string>("metadataId");
            }
        }

        public PaperSE() { }

        #region 发射命令

        /// <summary>
        /// 设置数据
        /// </summary>
        /// <param name="data"></param>
        public void Set(string expression)
        {
            this.View.WriteCode(string.Format("{0}.proxy().set({1});", this.Id, expression));
        }

        /// <summary>
        /// 设置数据
        /// </summary>
        /// <param name="data"></param>
        public void Set(object value)
        {
            this.View.WriteCode(string.Format("{0}.proxy().set({1});", this.Id, JSON.GetCode(value)));
        }


        public void Load(string paperMetadataId,Action callBack)
        {
            this.View.WriteCode(string.Format("{0}.proxy().load({1},", this.Id, JSON.GetCode(paperMetadataId)));
            this.View.WriteCode("function() {");
            callBack();
            this.View.WriteCode("}");
            this.View.WriteCode(");");
        }

        #endregion


    }
}