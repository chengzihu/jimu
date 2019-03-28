﻿using Microsoft.Extensions.Logging;
using MiniDDD.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jimu.Server.Repository.MiniDDD.EFIntegration
{
    public class MiniDDDEFOptions
    {
        public string ConnectionString { get; set; }
        public DbType DbType { get; set; }

        /// <summary>
        /// where table model (which inherite IDBModel) assembly is
        /// </summary>
        public string TableModelAssemblyName { get; set; }

        /// <summary>
        /// enable logging sql, this will effect lower perfermance, always just using in debug
        /// </summary>
        public bool OpenLogTrace { get; set; }

        /// <summary>
        /// log level, default debug 
        /// </summary>
        public LogLevel LogLevel { get; set; } = LogLevel.Debug;
    }
}
