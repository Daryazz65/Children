﻿using Children.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Children
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ZininaMatveevaChildrenEntities context = new ZininaMatveevaChildrenEntities();
        public static ZininaMatveevaChildrenEntities GetContext()
        {
            if (context == null)
            {
                context = new ZininaMatveevaChildrenEntities();
            }
            return context;
        }
    }
}
