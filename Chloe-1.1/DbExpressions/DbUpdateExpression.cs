﻿using Chloe.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chloe.DbExpressions
{
    class DbDeleteExpression : DbExpression
    {
        DbTable _table;
        DbExpression _condition;
        public DbDeleteExpression(DbTable table)
            : this(table, null)
        {
        }
        public DbDeleteExpression(DbTable table, DbExpression condition)
            : base(DbExpressionType.Delete, UtilConstants.TypeOfVoid)
        {
            Utils.CheckNull(table);

            this._table = table;
            this._condition = condition;
        }

        public DbTable Table { get { return this._table; } }
        public DbExpression Condition { get { return this._condition; } }

        public override T Accept<T>(DbExpressionVisitor<T> visitor)
        {
            throw new NotImplementedException();
        }
    }

    class DbUpdateExpression : DbExpression
    {
        DbTable _table;
        DbExpression _condition;
        public DbUpdateExpression(DbTable table)
            : this(table, null)
        {
        }
        public DbUpdateExpression(DbTable table, DbExpression condition)
            : base(DbExpressionType.Update, UtilConstants.TypeOfVoid)
        {
            Utils.CheckNull(table);

            this._table = table;
            this._condition = condition;
            this.UpdateColumns = new Dictionary<DbColumn, DbExpression>();
        }

        public DbTable Table { get { return this._table; } }
        public Dictionary<DbColumn, DbExpression> UpdateColumns { get; private set; }
        public DbExpression Condition { get { return this._condition; } }

        public override T Accept<T>(DbExpressionVisitor<T> visitor)
        {
            throw new NotImplementedException();
        }
    }
}