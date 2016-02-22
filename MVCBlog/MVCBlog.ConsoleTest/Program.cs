﻿using MVCBlog.Common;
using MVCBlog.Entities.Models;
using MVCBlog.Repository;
using MVCBlog.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MVCBlog.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //PostService service = new PostService(new MVCBlogContext());
            //Func<List<PostInfo>> getdb = () => service.GetPosts();

            //var res = Common.TaskExtensions.GetItemAsync(getdb);
            //var list = res.Result;
            //Console.ReadLine();

        }

        public static async Task<T> GetItemAsync<T>(Func<T> GetItem)
        {
            var res = await FindItemAsync(GetItem);
            return res;
        }

        public static Task<T> FindItemAsync<T>(Func<T> GetItem)
        {
            return Task<T>.Run(GetItem);
        }
    }
}
