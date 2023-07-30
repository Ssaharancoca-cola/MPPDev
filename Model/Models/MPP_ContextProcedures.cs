﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Model.Models
{
    public partial class MPP_Context
    {
        private IMPP_ContextProcedures _procedures;

        public virtual IMPP_ContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new MPP_ContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public IMPP_ContextProcedures GetProcedures()
        {
            return Procedures;
        }

        protected void OnModelCreatingGeneratedProcedures(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MPP_LOAD_CHKResult>().HasNoKey().ToView(null);
        }
    }

    public partial class MPP_ContextProcedures : IMPP_ContextProcedures
    {
        private readonly MPP_Context _context;

        public MPP_ContextProcedures(MPP_Context context)
        {
            _context = context;
        }

        public virtual async Task<int> GET_VIEW_NAMEAsync(int? i_entity_type_id, string i_user_id, OutputParameter<string> view_name, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterview_name = new SqlParameter
            {
                ParameterName = "view_name",
                Size = 255,
                Direction = System.Data.ParameterDirection.InputOutput,
                Value = view_name?._value ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.VarChar,
            };
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "i_entity_type_id",
                    Value = i_entity_type_id ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "i_user_id",
                    Size = 255,
                    Value = i_user_id ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterview_name,
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[GET_VIEW_NAME] @i_entity_type_id, @i_user_id, @view_name OUTPUT", sqlParameters, cancellationToken);

            view_name.SetValue(parameterview_name.Value);
            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<int> MPP_ENTITY_SEC_BASE_VIEWS_FN_PROCAsync(int? I_ENTITY_TYPE_ID, string I_USER_ID, OutputParameter<string> I_RESULT, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterI_RESULT = new SqlParameter
            {
                ParameterName = "I_RESULT",
                Size = -1,
                Direction = System.Data.ParameterDirection.InputOutput,
                Value = I_RESULT?._value ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.VarChar,
            };
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "I_ENTITY_TYPE_ID",
                    Value = I_ENTITY_TYPE_ID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "I_USER_ID",
                    Size = 50,
                    Value = I_USER_ID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterI_RESULT,
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[MPP_ENTITY_SEC_BASE_VIEWS_FN_PROC] @I_ENTITY_TYPE_ID, @I_USER_ID, @I_RESULT OUTPUT", sqlParameters, cancellationToken);

            I_RESULT.SetValue(parameterI_RESULT.Value);
            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<MPP_LOAD_CHKResult>> MPP_LOAD_CHKAsync(string i_Session_id, string i_entity_type_id, string i_user_id, decimal? i_suppress_warnings, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "i_Session_id",
                    Size = 100,
                    Value = i_Session_id ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "i_entity_type_id",
                    Size = 100,
                    Value = i_entity_type_id ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "i_user_id",
                    Size = 100,
                    Value = i_user_id ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "i_suppress_warnings",
                    Precision = 18,
                    Value = i_suppress_warnings ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Decimal,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<MPP_LOAD_CHKResult>("EXEC @returnValue = [dbo].[MPP_LOAD_CHK] @i_Session_id, @i_entity_type_id, @i_user_id, @i_suppress_warnings", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}
