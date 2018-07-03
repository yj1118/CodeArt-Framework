﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Hosting;
using System.Text;

using CodeArt.AOP;

namespace CodeArt.Web.WebPages
{
    public class WebPageInitializer : AspectInitializerBase
    {
        public WebPageInitializer() { }

        public override void Init()
        {
            var context = WebPageContext.Current;
            SetContentType(context);
            SetCompressEncoding(context);
        }

        #region contentType

        private void SetContentType(WebPageContext context)
        {
            context.Response.ContentType = GetContentType(context);
            //需要设置编码，否则会乱码
            context.Response.ContentEncoding = Encoding.UTF8;
            context.Response.Charset = "utf-8";
        }

        /// <summary>
        /// 获取输出流的 HTTP MIME 类型
        /// </summary>
        /// <returns></returns>
        protected virtual string GetContentType(WebPageContext context)
        {
            string ext = GetExtension(context);
            switch (ext)
            {
                case ".png":
                    return "image/png";
                case ".gif":
                    return "image/gif";
                case ".jpg":
                case ".jpeg":
                    return "image/jpeg";
                case ".css":
                    return "text/css";
                case ".js":
                    return "application/x-javascript";
                case ".htm":
                case ".html":
                    return "text/html";
                case ".swf":
                    return "application/x-shockwave-flash";
                case ".mp3":
                    return "audio/mpeg";
                case ".mp4":
                    return "video/mp4";
                case ".m4v":
                    return "video/x-m4v";
                case ".ogv":
                    return "video/ogg";
                case ".webmv":
                    return "video/webmv";
                case ".webm":
                    return "video/webm";
            }
            return null;
        }

        protected virtual string GetExtension(WebPageContext context)
        {
            return context.Request.CurrentExecutionFilePathExtension;
        }

        #endregion

        private void SetCompressEncoding(WebPageContext context)
        {
            if (!context.IsGET) return;
            ICompressor cpor = CompressorFactory.Create(context);
            if (cpor.IsAccepted(context)) cpor.SetEncoding(context); //支持压缩
        }

        public static WebPageInitializer Instance = new WebPageInitializer();

    }
}