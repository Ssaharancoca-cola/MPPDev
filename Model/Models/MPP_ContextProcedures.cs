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
            modelBuilder.Entity<GET_MPP_WORKFLOW_SAVEResult>().HasNoKey().ToView(null);
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

        public virtual async Task<List<GET_MPP_WORKFLOW_SAVEResult>> GET_MPP_WORKFLOW_SAVEAsync(string i_Session_Id, int? i_entity_type_id, string i_Approver_Id, string i_status, OutputParameter<int?> resultval, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterresultval = new SqlParameter
            {
                ParameterName = "resultval",
                Direction = System.Data.ParameterDirection.InputOutput,
                Value = resultval?._value ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.Int,
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
                    ParameterName = "i_Session_Id",
                    Size = 100,
                    Value = i_Session_Id ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "i_entity_type_id",
                    Value = i_entity_type_id ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "i_Approver_Id",
                    Size = 100,
                    Value = i_Approver_Id ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "i_status",
                    Size = 100,
                    Value = i_status ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterresultval,
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<GET_MPP_WORKFLOW_SAVEResult>("EXEC @returnValue = [dbo].[GET_MPP_WORKFLOW_SAVE] @i_Session_Id, @i_entity_type_id, @i_Approver_Id, @i_status, @resultval OUTPUT", sqlParameters, cancellationToken);

            resultval.SetValue(parameterresultval.Value);
            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
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

        public virtual async Task<int> MPP_ENTITY_USER_SEC_VIEWS_LOVAsync(int? i_entity_type_id, string i_user_id, OutputParameter<string> i_result, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameteri_result = new SqlParameter
            {
                ParameterName = "i_result",
                Size = -1,
                Direction = System.Data.ParameterDirection.InputOutput,
                Value = i_result?._value ?? Convert.DBNull,
                SqlDbType = System.Data.SqlDbType.NVarChar,
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
                    Size = 100,
                    Value = i_user_id ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                parameteri_result,
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[MPP_ENTITY_USER_SEC_VIEWS_LOV] @i_entity_type_id, @i_user_id, @i_result OUTPUT", sqlParameters, cancellationToken);

            i_result.SetValue(parameteri_result.Value);
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

        public virtual async Task<int> MPP_REFRESH_ROW_SECURITYAsync(string I_USER_ID, string I_ENTITY_ID, string I_DIM, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
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
                    ParameterName = "I_USER_ID",
                    Size = -1,
                    Value = I_USER_ID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "I_ENTITY_ID",
                    Size = -1,
                    Value = I_ENTITY_ID ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "I_DIM",
                    Size = -1,
                    Value = I_DIM ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[MPP_REFRESH_ROW_SECURITY] @I_USER_ID, @I_ENTITY_ID, @I_DIM", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<int> UPDATE_USER_PRIVILAGEAsync(string UserId, int? EntityTypeId, int? RoleId, string ApprId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
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
                    ParameterName = "UserId",
                    Size = 100,
                    Value = UserId ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                new SqlParameter
                {
                    ParameterName = "EntityTypeId",
                    Value = EntityTypeId ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "RoleId",
                    Value = RoleId ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "ApprId",
                    Size = 100,
                    Value = ApprId ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.NVarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[UPDATE_USER_PRIVILAGE] @UserId, @EntityTypeId, @RoleId, @ApprId", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}
