﻿
using System;
namespace Entity.TEAMTOOL
{
    /// <summary>
    /// 本类中的(系统生成代码部分)由代码生成器自动生成,如果数据库表结构有所改动请及时更新
    /// DataBase="TEAMTOOL" 
    /// Table="DATABASE_SQL_MY_IGNORE"
    /// Columns="WEBMANAGER_NAME,SQL_MD5,SOURCE_MD5,SQL_ERROR,TEXT_ANALYSIS,DATABASE_IP,DATABASE_USER,DATABASE_NAME,TABLE_NAME,CREATION_TIME,LAST_EXECUTION_TIME,EXECUTION_COUNT,TOTAL_WORKER_TIME,LAST_WORKER_TIME,MIN_WORKER_TIME,MAX_WORKER_TIME,TOTAL_PHYSICAL_READS,LAST_PHYSICAL_READS,MIN_PHYSICAL_READS,MAX_PHYSICAL_READS,TOTAL_LOGICAL_WRITES,LAST_LOGICAL_WRITES,MIN_LOGICAL_WRITES,MAX_LOGICAL_WRITES,TOTAL_LOGICAL_READS,LAST_LOGICAL_READS,MIN_LOGICAL_READS,MAX_LOGICAL_READS,TOTAL_ELAPSED_TIME,LAST_ELAPSED_TIME,MIN_ELAPSED_TIME,MAX_ELAPSED_TIME,TOTAL_ROWS,LAST_ROWS,MIN_ROWS,MAX_ROWS,CREATETIME"
    /// PrimaryKeys="WEBMANAGER_NAME,SQL_MD5"
    /// </summary>
    public sealed class DATABASE_SQL_MY_IGNORE : Entity.TEAMTOOL.EntityBase
    {
        #region 系统生成代码，请不要动 生成日期:2016/5/10 11:18:35
        #region 属性
        /// <summary>
        ///   VARCHAR(50)  NOT NULL
        ///	主健之一，其他主健还有：WEBMANAGER_NAME,SQL_MD5
        /// </summary>
        public string WEBMANAGER_NAME
        {
            get
            {
                return ColumnValues[0];
            }
            set
            {
                ColumnValues[0] = value; UpdateStatus[0] = 1;
            }
        }
        /// <summary>
        ///    VARCHAR(50)  NOT NULL
        ///	主健之一，其他主健还有：WEBMANAGER_NAME,SQL_MD5
        /// </summary>
        public string SQL_MD5
        {
            get
            {
                return ColumnValues[1];
            }
            set
            {
                ColumnValues[1] = value; UpdateStatus[1] = 1;
            }
        }
        /// <summary>
        /// 来源出处的MD5加密串，包括url和命名空间、函数、SQL参数等信息  VARCHAR(50)  NULL
        /// </summary>
        public string SOURCE_MD5
        {
            get
            {
                return ColumnValues[2];
            }
            set
            {
                ColumnValues[2] = value; UpdateStatus[2] = 1;
            }
        }
        /// <summary>
        ///    NVARCHAR(2000)  NULL
        /// </summary>
        public string SQL_ERROR
        {
            get
            {
                return ColumnValues[3];
            }
            set
            {
                ColumnValues[3] = value; UpdateStatus[3] = 1;
            }
        }
        /// <summary>
        ///    VARCHAR(-1)  NULL
        /// </summary>
        public string TEXT_ANALYSIS
        {
            get
            {
                return ColumnValues[4];
            }
            set
            {
                ColumnValues[4] = value; UpdateStatus[4] = 1;
            }
        }
        /// <summary>
        /// 数据库IP  VARCHAR(50)  NULL
        /// </summary>
        public string DATABASE_IP
        {
            get
            {
                return ColumnValues[5];
            }
            set
            {
                ColumnValues[5] = value; UpdateStatus[5] = 1;
            }
        }
        /// <summary>
        /// 数据库用户  VARCHAR(100)  NULL
        /// </summary>
        public string DATABASE_USER
        {
            get
            {
                return ColumnValues[6];
            }
            set
            {
                ColumnValues[6] = value; UpdateStatus[6] = 1;
            }
        }
        /// <summary>
        ///    VARCHAR(50)  NULL
        /// </summary>
        public string DATABASE_NAME
        {
            get
            {
                return ColumnValues[7];
            }
            set
            {
                ColumnValues[7] = value; UpdateStatus[7] = 1;
            }
        }
        /// <summary>
        ///    VARCHAR(50)  NULL
        /// </summary>
        public string TABLE_NAME
        {
            get
            {
                return ColumnValues[8];
            }
            set
            {
                ColumnValues[8] = value; UpdateStatus[8] = 1;
            }
        }
        /// <summary>
        /// 编译计划的时间。  DATETIME(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 CREATION_TIME_ToString 更加准确
        /// </summary>
        public DateTime CREATION_TIME
        {
            set
            {
                ColumnValues[9] = value.ToString("yyyy-MM-dd HH:mm:ss.fff"); UpdateStatus[9] = 1;
            }
        }
        /// <summary>
        /// 编译计划的时间。  DATETIME(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 CREATION_TIME
        /// </summary>
        public string CREATION_TIME_ToString
        {
            get
            {
                return ColumnValues[9];
            }
        }
        /// <summary>
        /// 上次开始执行计划的时间。  DATETIME(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 LAST_EXECUTION_TIME_ToString 更加准确
        /// </summary>
        public DateTime LAST_EXECUTION_TIME
        {
            set
            {
                ColumnValues[10] = value.ToString("yyyy-MM-dd HH:mm:ss.fff"); UpdateStatus[10] = 1;
            }
        }
        /// <summary>
        /// 上次开始执行计划的时间。  DATETIME(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 LAST_EXECUTION_TIME
        /// </summary>
        public string LAST_EXECUTION_TIME_ToString
        {
            get
            {
                return ColumnValues[10];
            }
        }
        /// <summary>
        /// 计划自上次编译以来所执行的次数  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 EXECUTION_COUNT_ToString 更加准确
        /// </summary>
        public long EXECUTION_COUNT
        {
            set
            {
                ColumnValues[11] = value.ToString(); UpdateStatus[11] = 1;
            }
        }
        /// <summary>
        /// 计划自上次编译以来所执行的次数  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 EXECUTION_COUNT
        /// </summary>
        public string EXECUTION_COUNT_ToString
        {
            get
            {
                return ColumnValues[11];
            }
        }
        /// <summary>
        /// 此计划自编译以来执行所用的 CPU 时间总量（以微秒为单位报告，但仅精确到毫秒）。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 TOTAL_WORKER_TIME_ToString 更加准确
        /// </summary>
        public long TOTAL_WORKER_TIME
        {
            set
            {
                ColumnValues[12] = value.ToString(); UpdateStatus[12] = 1;
            }
        }
        /// <summary>
        /// 此计划自编译以来执行所用的 CPU 时间总量（以微秒为单位报告，但仅精确到毫秒）。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 TOTAL_WORKER_TIME
        /// </summary>
        public string TOTAL_WORKER_TIME_ToString
        {
            get
            {
                return ColumnValues[12];
            }
        }
        /// <summary>
        /// 上次执行计划所用的 CPU 时间（以微秒为单位报告，但仅精确到毫秒）。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 LAST_WORKER_TIME_ToString 更加准确
        /// </summary>
        public long LAST_WORKER_TIME
        {
            set
            {
                ColumnValues[13] = value.ToString(); UpdateStatus[13] = 1;
            }
        }
        /// <summary>
        /// 上次执行计划所用的 CPU 时间（以微秒为单位报告，但仅精确到毫秒）。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 LAST_WORKER_TIME
        /// </summary>
        public string LAST_WORKER_TIME_ToString
        {
            get
            {
                return ColumnValues[13];
            }
        }
        /// <summary>
        /// 此计划在单次执行期间所用的最小 CPU 时间（以微秒为单位报告，但仅精确到毫秒）。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 MIN_WORKER_TIME_ToString 更加准确
        /// </summary>
        public long MIN_WORKER_TIME
        {
            set
            {
                ColumnValues[14] = value.ToString(); UpdateStatus[14] = 1;
            }
        }
        /// <summary>
        /// 此计划在单次执行期间所用的最小 CPU 时间（以微秒为单位报告，但仅精确到毫秒）。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 MIN_WORKER_TIME
        /// </summary>
        public string MIN_WORKER_TIME_ToString
        {
            get
            {
                return ColumnValues[14];
            }
        }
        /// <summary>
        /// 此计划在单次执行期间所用的最大 CPU 时间（以微秒为单位报告，但仅精确到毫秒）  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 MAX_WORKER_TIME_ToString 更加准确
        /// </summary>
        public long MAX_WORKER_TIME
        {
            set
            {
                ColumnValues[15] = value.ToString(); UpdateStatus[15] = 1;
            }
        }
        /// <summary>
        /// 此计划在单次执行期间所用的最大 CPU 时间（以微秒为单位报告，但仅精确到毫秒）  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 MAX_WORKER_TIME
        /// </summary>
        public string MAX_WORKER_TIME_ToString
        {
            get
            {
                return ColumnValues[15];
            }
        }
        /// <summary>
        /// 此计划自编译后在执行期间所执行的物理读取总次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 TOTAL_PHYSICAL_READS_ToString 更加准确
        /// </summary>
        public long TOTAL_PHYSICAL_READS
        {
            set
            {
                ColumnValues[16] = value.ToString(); UpdateStatus[16] = 1;
            }
        }
        /// <summary>
        /// 此计划自编译后在执行期间所执行的物理读取总次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 TOTAL_PHYSICAL_READS
        /// </summary>
        public string TOTAL_PHYSICAL_READS_ToString
        {
            get
            {
                return ColumnValues[16];
            }
        }
        /// <summary>
        /// 上次执行计划时所执行的物理读取次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 LAST_PHYSICAL_READS_ToString 更加准确
        /// </summary>
        public long LAST_PHYSICAL_READS
        {
            set
            {
                ColumnValues[17] = value.ToString(); UpdateStatus[17] = 1;
            }
        }
        /// <summary>
        /// 上次执行计划时所执行的物理读取次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 LAST_PHYSICAL_READS
        /// </summary>
        public string LAST_PHYSICAL_READS_ToString
        {
            get
            {
                return ColumnValues[17];
            }
        }
        /// <summary>
        /// 此计划在单个执行期间所执行的最少物理读取次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 MIN_PHYSICAL_READS_ToString 更加准确
        /// </summary>
        public long MIN_PHYSICAL_READS
        {
            set
            {
                ColumnValues[18] = value.ToString(); UpdateStatus[18] = 1;
            }
        }
        /// <summary>
        /// 此计划在单个执行期间所执行的最少物理读取次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 MIN_PHYSICAL_READS
        /// </summary>
        public string MIN_PHYSICAL_READS_ToString
        {
            get
            {
                return ColumnValues[18];
            }
        }
        /// <summary>
        /// 此计划在单个执行期间所执行的最多物理读取次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 MAX_PHYSICAL_READS_ToString 更加准确
        /// </summary>
        public long MAX_PHYSICAL_READS
        {
            set
            {
                ColumnValues[19] = value.ToString(); UpdateStatus[19] = 1;
            }
        }
        /// <summary>
        /// 此计划在单个执行期间所执行的最多物理读取次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 MAX_PHYSICAL_READS
        /// </summary>
        public string MAX_PHYSICAL_READS_ToString
        {
            get
            {
                return ColumnValues[19];
            }
        }
        /// <summary>
        /// 此计划自编译后在执行期间所执行的逻辑写入总次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 TOTAL_LOGICAL_WRITES_ToString 更加准确
        /// </summary>
        public long TOTAL_LOGICAL_WRITES
        {
            set
            {
                ColumnValues[20] = value.ToString(); UpdateStatus[20] = 1;
            }
        }
        /// <summary>
        /// 此计划自编译后在执行期间所执行的逻辑写入总次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 TOTAL_LOGICAL_WRITES
        /// </summary>
        public string TOTAL_LOGICAL_WRITES_ToString
        {
            get
            {
                return ColumnValues[20];
            }
        }
        /// <summary>
        /// 上次执行计划时变脏的缓冲池页数。如果页已变脏（已修改），则不计入写次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 LAST_LOGICAL_WRITES_ToString 更加准确
        /// </summary>
        public long LAST_LOGICAL_WRITES
        {
            set
            {
                ColumnValues[21] = value.ToString(); UpdateStatus[21] = 1;
            }
        }
        /// <summary>
        /// 上次执行计划时变脏的缓冲池页数。如果页已变脏（已修改），则不计入写次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 LAST_LOGICAL_WRITES
        /// </summary>
        public string LAST_LOGICAL_WRITES_ToString
        {
            get
            {
                return ColumnValues[21];
            }
        }
        /// <summary>
        /// 此计划在单个执行期间所执行的最少逻辑写入次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 MIN_LOGICAL_WRITES_ToString 更加准确
        /// </summary>
        public long MIN_LOGICAL_WRITES
        {
            set
            {
                ColumnValues[22] = value.ToString(); UpdateStatus[22] = 1;
            }
        }
        /// <summary>
        /// 此计划在单个执行期间所执行的最少逻辑写入次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 MIN_LOGICAL_WRITES
        /// </summary>
        public string MIN_LOGICAL_WRITES_ToString
        {
            get
            {
                return ColumnValues[22];
            }
        }
        /// <summary>
        /// 此计划在单个执行期间所执行的最多逻辑写入次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 MAX_LOGICAL_WRITES_ToString 更加准确
        /// </summary>
        public long MAX_LOGICAL_WRITES
        {
            set
            {
                ColumnValues[23] = value.ToString(); UpdateStatus[23] = 1;
            }
        }
        /// <summary>
        /// 此计划在单个执行期间所执行的最多逻辑写入次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 MAX_LOGICAL_WRITES
        /// </summary>
        public string MAX_LOGICAL_WRITES_ToString
        {
            get
            {
                return ColumnValues[23];
            }
        }
        /// <summary>
        /// 此计划自编译后在执行期间所执行的逻辑读取总次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 TOTAL_LOGICAL_READS_ToString 更加准确
        /// </summary>
        public long TOTAL_LOGICAL_READS
        {
            set
            {
                ColumnValues[24] = value.ToString(); UpdateStatus[24] = 1;
            }
        }
        /// <summary>
        /// 此计划自编译后在执行期间所执行的逻辑读取总次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 TOTAL_LOGICAL_READS
        /// </summary>
        public string TOTAL_LOGICAL_READS_ToString
        {
            get
            {
                return ColumnValues[24];
            }
        }
        /// <summary>
        /// 上次执行计划时所执行的逻辑读取次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 LAST_LOGICAL_READS_ToString 更加准确
        /// </summary>
        public long LAST_LOGICAL_READS
        {
            set
            {
                ColumnValues[25] = value.ToString(); UpdateStatus[25] = 1;
            }
        }
        /// <summary>
        /// 上次执行计划时所执行的逻辑读取次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 LAST_LOGICAL_READS
        /// </summary>
        public string LAST_LOGICAL_READS_ToString
        {
            get
            {
                return ColumnValues[25];
            }
        }
        /// <summary>
        /// 此计划在单个执行期间所执行的最少逻辑读取次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 MIN_LOGICAL_READS_ToString 更加准确
        /// </summary>
        public long MIN_LOGICAL_READS
        {
            set
            {
                ColumnValues[26] = value.ToString(); UpdateStatus[26] = 1;
            }
        }
        /// <summary>
        /// 此计划在单个执行期间所执行的最少逻辑读取次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 MIN_LOGICAL_READS
        /// </summary>
        public string MIN_LOGICAL_READS_ToString
        {
            get
            {
                return ColumnValues[26];
            }
        }
        /// <summary>
        /// 此计划在单个执行期间所执行的最多逻辑读取次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 MAX_LOGICAL_READS_ToString 更加准确
        /// </summary>
        public long MAX_LOGICAL_READS
        {
            set
            {
                ColumnValues[27] = value.ToString(); UpdateStatus[27] = 1;
            }
        }
        /// <summary>
        /// 此计划在单个执行期间所执行的最多逻辑读取次数。
        ///当查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 MAX_LOGICAL_READS
        /// </summary>
        public string MAX_LOGICAL_READS_ToString
        {
            get
            {
                return ColumnValues[27];
            }
        }
        /// <summary>
        /// 上次完成执行此计划所用的总时间（以微秒为单位报告，但仅精确到毫秒）。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 TOTAL_ELAPSED_TIME_ToString 更加准确
        /// </summary>
        public long TOTAL_ELAPSED_TIME
        {
            set
            {
                ColumnValues[28] = value.ToString(); UpdateStatus[28] = 1;
            }
        }
        /// <summary>
        /// 上次完成执行此计划所用的总时间（以微秒为单位报告，但仅精确到毫秒）。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 TOTAL_ELAPSED_TIME
        /// </summary>
        public string TOTAL_ELAPSED_TIME_ToString
        {
            get
            {
                return ColumnValues[28];
            }
        }
        /// <summary>
        /// 最近一次完成执行此计划所用的时间（以微秒为单位报告，但仅精确到毫秒）。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 LAST_ELAPSED_TIME_ToString 更加准确
        /// </summary>
        public long LAST_ELAPSED_TIME
        {
            set
            {
                ColumnValues[29] = value.ToString(); UpdateStatus[29] = 1;
            }
        }
        /// <summary>
        /// 最近一次完成执行此计划所用的时间（以微秒为单位报告，但仅精确到毫秒）。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 LAST_ELAPSED_TIME
        /// </summary>
        public string LAST_ELAPSED_TIME_ToString
        {
            get
            {
                return ColumnValues[29];
            }
        }
        /// <summary>
        /// 任何一次完成执行此计划所用的最小时间（以微秒为单位报告，但仅精确到毫秒）。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 MIN_ELAPSED_TIME_ToString 更加准确
        /// </summary>
        public long MIN_ELAPSED_TIME
        {
            set
            {
                ColumnValues[30] = value.ToString(); UpdateStatus[30] = 1;
            }
        }
        /// <summary>
        /// 任何一次完成执行此计划所用的最小时间（以微秒为单位报告，但仅精确到毫秒）。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 MIN_ELAPSED_TIME
        /// </summary>
        public string MIN_ELAPSED_TIME_ToString
        {
            get
            {
                return ColumnValues[30];
            }
        }
        /// <summary>
        /// 任何一次完成执行此计划所用的最大时间（以微秒为单位报告，但仅精确到毫秒）。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 MAX_ELAPSED_TIME_ToString 更加准确
        /// </summary>
        public long MAX_ELAPSED_TIME
        {
            set
            {
                ColumnValues[31] = value.ToString(); UpdateStatus[31] = 1;
            }
        }
        /// <summary>
        /// 任何一次完成执行此计划所用的最大时间（以微秒为单位报告，但仅精确到毫秒）。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 MAX_ELAPSED_TIME
        /// </summary>
        public string MAX_ELAPSED_TIME_ToString
        {
            get
            {
                return ColumnValues[31];
            }
        }
        /// <summary>
        /// 查询返回的总行数。不可为 null。
        ///当本机编译的存储过程查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 TOTAL_ROWS_ToString 更加准确
        /// </summary>
        public long TOTAL_ROWS
        {
            set
            {
                ColumnValues[32] = value.ToString(); UpdateStatus[32] = 1;
            }
        }
        /// <summary>
        /// 查询返回的总行数。不可为 null。
        ///当本机编译的存储过程查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 TOTAL_ROWS
        /// </summary>
        public string TOTAL_ROWS_ToString
        {
            get
            {
                return ColumnValues[32];
            }
        }
        /// <summary>
        /// 上一次执行查询返回的行数。不可为 null。
        ///当本机编译的存储过程查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 LAST_ROWS_ToString 更加准确
        /// </summary>
        public long LAST_ROWS
        {
            set
            {
                ColumnValues[33] = value.ToString(); UpdateStatus[33] = 1;
            }
        }
        /// <summary>
        /// 上一次执行查询返回的行数。不可为 null。
        ///当本机编译的存储过程查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 LAST_ROWS
        /// </summary>
        public string LAST_ROWS_ToString
        {
            get
            {
                return ColumnValues[33];
            }
        }
        /// <summary>
        /// 查询自上次编译以来已执行计划的次数所返回的最小行数。不可为 null。
        ///当本机编译的存储过程查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 MIN_ROWS_ToString 更加准确
        /// </summary>
        public long MIN_ROWS
        {
            set
            {
                ColumnValues[34] = value.ToString(); UpdateStatus[34] = 1;
            }
        }
        /// <summary>
        /// 查询自上次编译以来已执行计划的次数所返回的最小行数。不可为 null。
        ///当本机编译的存储过程查询内存优化的表时，此项将始终为 0。  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 MIN_ROWS
        /// </summary>
        public string MIN_ROWS_ToString
        {
            get
            {
                return ColumnValues[34];
            }
        }
        /// <summary>
        /// 查询自上次编译以来已执行计划的次数所返回的最大行数。不可为 null。
        ///当本机编译的存储过程查询内存优化的表时，此项将始终为 0  BIGINT(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 MAX_ROWS_ToString 更加准确
        /// </summary>
        public long MAX_ROWS
        {
            set
            {
                ColumnValues[35] = value.ToString(); UpdateStatus[35] = 1;
            }
        }
        /// <summary>
        /// 查询自上次编译以来已执行计划的次数所返回的最大行数。不可为 null。
        ///当本机编译的存储过程查询内存优化的表时，此项将始终为 0  BIGINT(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 MAX_ROWS
        /// </summary>
        public string MAX_ROWS_ToString
        {
            get
            {
                return ColumnValues[35];
            }
        }
        /// <summary>
        ///   DATETIME(8)  NULL
        ///	只写属性，如果非要读取该字段的字符串,建议使用 CREATETIME_ToString 更加准确
        ///	默认值:getdate
        /// </summary>
        public DateTime CREATETIME
        {
            set
            {
                ColumnValues[36] = value.ToString("yyyy-MM-dd HH:mm:ss.fff"); UpdateStatus[36] = 1;
            }
        }
        /// <summary>
        ///   DATETIME(8)  NULL
        ///	只读属性，如果非要写入该字段，请使用 CREATETIME
        ///	默认值:getdate
        /// </summary>
        public string CREATETIME_ToString
        {
            get
            {
                return ColumnValues[36];
            }
        }

        #endregion
        #region  同名列变量 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用以下同名列变量
        /// <summary>
        ///  返回 "WEBMANAGER_NAME", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _WEBMANAGER_NAME = "WEBMANAGER_NAME";
        /// <summary>
        ///   返回 "SQL_MD5", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _SQL_MD5 = "SQL_MD5";
        /// <summary>
        /// 来源出处的MD5加密串，包括url和命名空间、函数、SQL参数等信息 返回 "SOURCE_MD5", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _SOURCE_MD5 = "SOURCE_MD5";
        /// <summary>
        ///   返回 "SQL_ERROR", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _SQL_ERROR = "SQL_ERROR";
        /// <summary>
        ///   返回 "TEXT_ANALYSIS", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _TEXT_ANALYSIS = "TEXT_ANALYSIS";
        /// <summary>
        /// 数据库IP 返回 "DATABASE_IP", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _DATABASE_IP = "DATABASE_IP";
        /// <summary>
        /// 数据库用户 返回 "DATABASE_USER", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _DATABASE_USER = "DATABASE_USER";
        /// <summary>
        ///   返回 "DATABASE_NAME", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _DATABASE_NAME = "DATABASE_NAME";
        /// <summary>
        ///   返回 "TABLE_NAME", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _TABLE_NAME = "TABLE_NAME";
        /// <summary>
        /// 编译计划的时间。 返回 "CREATION_TIME", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _CREATION_TIME = "CREATION_TIME";
        /// <summary>
        /// 上次开始执行计划的时间。 返回 "LAST_EXECUTION_TIME", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _LAST_EXECUTION_TIME = "LAST_EXECUTION_TIME";
        /// <summary>
        /// 计划自上次编译以来所执行的次数 返回 "EXECUTION_COUNT", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _EXECUTION_COUNT = "EXECUTION_COUNT";
        /// <summary>
        /// 此计划自编译以来执行所用的 CPU 时间总量（以微秒为单位报告，但仅精确到毫秒）。 返回 "TOTAL_WORKER_TIME", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _TOTAL_WORKER_TIME = "TOTAL_WORKER_TIME";
        /// <summary>
        /// 上次执行计划所用的 CPU 时间（以微秒为单位报告，但仅精确到毫秒）。 返回 "LAST_WORKER_TIME", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _LAST_WORKER_TIME = "LAST_WORKER_TIME";
        /// <summary>
        /// 此计划在单次执行期间所用的最小 CPU 时间（以微秒为单位报告，但仅精确到毫秒）。 返回 "MIN_WORKER_TIME", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _MIN_WORKER_TIME = "MIN_WORKER_TIME";
        /// <summary>
        /// 此计划在单次执行期间所用的最大 CPU 时间（以微秒为单位报告，但仅精确到毫秒） 返回 "MAX_WORKER_TIME", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _MAX_WORKER_TIME = "MAX_WORKER_TIME";
        /// <summary>
        /// 此计划自编译后在执行期间所执行的物理读取总次数。
        ///当查询内存优化的表时，此项将始终为 0。 返回 "TOTAL_PHYSICAL_READS", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _TOTAL_PHYSICAL_READS = "TOTAL_PHYSICAL_READS";
        /// <summary>
        /// 上次执行计划时所执行的物理读取次数。
        ///当查询内存优化的表时，此项将始终为 0。 返回 "LAST_PHYSICAL_READS", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _LAST_PHYSICAL_READS = "LAST_PHYSICAL_READS";
        /// <summary>
        /// 此计划在单个执行期间所执行的最少物理读取次数。
        ///当查询内存优化的表时，此项将始终为 0。 返回 "MIN_PHYSICAL_READS", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _MIN_PHYSICAL_READS = "MIN_PHYSICAL_READS";
        /// <summary>
        /// 此计划在单个执行期间所执行的最多物理读取次数。
        ///当查询内存优化的表时，此项将始终为 0。 返回 "MAX_PHYSICAL_READS", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _MAX_PHYSICAL_READS = "MAX_PHYSICAL_READS";
        /// <summary>
        /// 此计划自编译后在执行期间所执行的逻辑写入总次数。
        ///当查询内存优化的表时，此项将始终为 0。 返回 "TOTAL_LOGICAL_WRITES", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _TOTAL_LOGICAL_WRITES = "TOTAL_LOGICAL_WRITES";
        /// <summary>
        /// 上次执行计划时变脏的缓冲池页数。如果页已变脏（已修改），则不计入写次数。
        ///当查询内存优化的表时，此项将始终为 0。 返回 "LAST_LOGICAL_WRITES", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _LAST_LOGICAL_WRITES = "LAST_LOGICAL_WRITES";
        /// <summary>
        /// 此计划在单个执行期间所执行的最少逻辑写入次数。
        ///当查询内存优化的表时，此项将始终为 0。 返回 "MIN_LOGICAL_WRITES", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _MIN_LOGICAL_WRITES = "MIN_LOGICAL_WRITES";
        /// <summary>
        /// 此计划在单个执行期间所执行的最多逻辑写入次数。
        ///当查询内存优化的表时，此项将始终为 0。 返回 "MAX_LOGICAL_WRITES", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _MAX_LOGICAL_WRITES = "MAX_LOGICAL_WRITES";
        /// <summary>
        /// 此计划自编译后在执行期间所执行的逻辑读取总次数。
        ///当查询内存优化的表时，此项将始终为 0。 返回 "TOTAL_LOGICAL_READS", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _TOTAL_LOGICAL_READS = "TOTAL_LOGICAL_READS";
        /// <summary>
        /// 上次执行计划时所执行的逻辑读取次数。
        ///当查询内存优化的表时，此项将始终为 0。 返回 "LAST_LOGICAL_READS", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _LAST_LOGICAL_READS = "LAST_LOGICAL_READS";
        /// <summary>
        /// 此计划在单个执行期间所执行的最少逻辑读取次数。
        ///当查询内存优化的表时，此项将始终为 0。 返回 "MIN_LOGICAL_READS", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _MIN_LOGICAL_READS = "MIN_LOGICAL_READS";
        /// <summary>
        /// 此计划在单个执行期间所执行的最多逻辑读取次数。
        ///当查询内存优化的表时，此项将始终为 0。 返回 "MAX_LOGICAL_READS", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _MAX_LOGICAL_READS = "MAX_LOGICAL_READS";
        /// <summary>
        /// 上次完成执行此计划所用的总时间（以微秒为单位报告，但仅精确到毫秒）。 返回 "TOTAL_ELAPSED_TIME", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _TOTAL_ELAPSED_TIME = "TOTAL_ELAPSED_TIME";
        /// <summary>
        /// 最近一次完成执行此计划所用的时间（以微秒为单位报告，但仅精确到毫秒）。 返回 "LAST_ELAPSED_TIME", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _LAST_ELAPSED_TIME = "LAST_ELAPSED_TIME";
        /// <summary>
        /// 任何一次完成执行此计划所用的最小时间（以微秒为单位报告，但仅精确到毫秒）。 返回 "MIN_ELAPSED_TIME", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _MIN_ELAPSED_TIME = "MIN_ELAPSED_TIME";
        /// <summary>
        /// 任何一次完成执行此计划所用的最大时间（以微秒为单位报告，但仅精确到毫秒）。 返回 "MAX_ELAPSED_TIME", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _MAX_ELAPSED_TIME = "MAX_ELAPSED_TIME";
        /// <summary>
        /// 查询返回的总行数。不可为 null。
        ///当本机编译的存储过程查询内存优化的表时，此项将始终为 0。 返回 "TOTAL_ROWS", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _TOTAL_ROWS = "TOTAL_ROWS";
        /// <summary>
        /// 上一次执行查询返回的行数。不可为 null。
        ///当本机编译的存储过程查询内存优化的表时，此项将始终为 0。 返回 "LAST_ROWS", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _LAST_ROWS = "LAST_ROWS";
        /// <summary>
        /// 查询自上次编译以来已执行计划的次数所返回的最小行数。不可为 null。
        ///当本机编译的存储过程查询内存优化的表时，此项将始终为 0。 返回 "MIN_ROWS", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _MIN_ROWS = "MIN_ROWS";
        /// <summary>
        /// 查询自上次编译以来已执行计划的次数所返回的最大行数。不可为 null。
        ///当本机编译的存储过程查询内存优化的表时，此项将始终为 0 返回 "MAX_ROWS", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _MAX_ROWS = "MAX_ROWS";
        /// <summary>
        ///  返回 "CREATETIME", 为了与数据库同步，避免列名写错，如果用到表的列名，请尽量使用同名列变量
        /// </summary>
        public readonly string _CREATETIME = "CREATETIME";

        #endregion
        #region 函数
        /// <summary>
        /// DATABASE_SQL_MY_IGNORE的构造函数
        /// </summary>
        public DATABASE_SQL_MY_IGNORE()
        {
            this.TableName = "DATABASE_SQL_MY_IGNORE";
            this.PrimaryKey = new string[] { _WEBMANAGER_NAME, _SQL_MD5 };

            this.columns = new string[] { _WEBMANAGER_NAME, _SQL_MD5, _SOURCE_MD5, _SQL_ERROR, _TEXT_ANALYSIS, _DATABASE_IP, _DATABASE_USER, _DATABASE_NAME, _TABLE_NAME, _CREATION_TIME, _LAST_EXECUTION_TIME, _EXECUTION_COUNT, _TOTAL_WORKER_TIME, _LAST_WORKER_TIME, _MIN_WORKER_TIME, _MAX_WORKER_TIME, _TOTAL_PHYSICAL_READS, _LAST_PHYSICAL_READS, _MIN_PHYSICAL_READS, _MAX_PHYSICAL_READS, _TOTAL_LOGICAL_WRITES, _LAST_LOGICAL_WRITES, _MIN_LOGICAL_WRITES, _MAX_LOGICAL_WRITES, _TOTAL_LOGICAL_READS, _LAST_LOGICAL_READS, _MIN_LOGICAL_READS, _MAX_LOGICAL_READS, _TOTAL_ELAPSED_TIME, _LAST_ELAPSED_TIME, _MIN_ELAPSED_TIME, _MAX_ELAPSED_TIME, _TOTAL_ROWS, _LAST_ROWS, _MIN_ROWS, _MAX_ROWS, _CREATETIME };
            this.SelectColumns = this.Columns;
            this.ColumnValues = new string[this.Columns.Length];
            this.UpdateStatus = new int[this.Columns.Length];
            for (int i = 0; i < this.Columns.Length; i++) { this.UpdateStatus[i] = 0; this.ColumnValues[i] = ""; };
        }
        /// <summary>
        /// 初始化表DATABASE_SQL_MY_IGNORE的各种相关值
        /// </summary>
        protected override void SetValuesOnInit()
        {
            if (this.DataTypes == null || this.DataTypes.Length == 0)
            {
                this.IsPrimaryKeys = new int[] { 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                this.DataTypes = new string[] { VARCHAR, VARCHAR, VARCHAR, NVARCHAR, VARCHAR, VARCHAR, VARCHAR, VARCHAR, VARCHAR, DATETIME, DATETIME, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, BIGINT, DATETIME };
                this.Lengths = new int[] { 50, 50, 50, 2000, -1, 50, 100, 50, 50, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8 };
                this.IsNullables = new int[] { 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
                this.DefaultValues = new string[] { " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "getdate" };
                this.Descriptions = new string[] { " ", " ", "来源出处的MD5加密串，包括url和命名空间、函数、SQL参数等信息", " ", " ", "数据库IP", "数据库用户", " ", " ", "编译计划的时间。", "上次开始执行计划的时间。", "计划自上次编译以来所执行的次数", "此计划自编译以来执行所用的 CPU 时间总量（以微秒为单位报告，但仅精确到毫秒）。", "上次执行计划所用的 CPU 时间（以微秒为单位报告，但仅精确到毫秒）。", "此计划在单次执行期间所用的最小 CPU 时间（以微秒为单位报告，但仅精确到毫秒）。", "此计划在单次执行期间所用的最大 CPU 时间（以微秒为单位报告，但仅精确到毫秒）", "此计划自编译后在执行期间所执行的物理读取总次数。,当查询内存优化的表时，此项将始终为 0。", "上次执行计划时所执行的物理读取次数。,当查询内存优化的表时，此项将始终为 0。", "此计划在单个执行期间所执行的最少物理读取次数。,当查询内存优化的表时，此项将始终为 0。", "此计划在单个执行期间所执行的最多物理读取次数。,当查询内存优化的表时，此项将始终为 0。", "此计划自编译后在执行期间所执行的逻辑写入总次数。,当查询内存优化的表时，此项将始终为 0。", "上次执行计划时变脏的缓冲池页数。如果页已变脏（已修改），则不计入写次数。,当查询内存优化的表时，此项将始终为 0。", "此计划在单个执行期间所执行的最少逻辑写入次数。,当查询内存优化的表时，此项将始终为 0。", "此计划在单个执行期间所执行的最多逻辑写入次数。,当查询内存优化的表时，此项将始终为 0。", "此计划自编译后在执行期间所执行的逻辑读取总次数。,当查询内存优化的表时，此项将始终为 0。", "上次执行计划时所执行的逻辑读取次数。,当查询内存优化的表时，此项将始终为 0。", "此计划在单个执行期间所执行的最少逻辑读取次数。,当查询内存优化的表时，此项将始终为 0。", "此计划在单个执行期间所执行的最多逻辑读取次数。,当查询内存优化的表时，此项将始终为 0。", "上次完成执行此计划所用的总时间（以微秒为单位报告，但仅精确到毫秒）。", "最近一次完成执行此计划所用的时间（以微秒为单位报告，但仅精确到毫秒）。", "任何一次完成执行此计划所用的最小时间（以微秒为单位报告，但仅精确到毫秒）。", "任何一次完成执行此计划所用的最大时间（以微秒为单位报告，但仅精确到毫秒）。", "查询返回的总行数。不可为 null。,当本机编译的存储过程查询内存优化的表时，此项将始终为 0。", "上一次执行查询返回的行数。不可为 null。,当本机编译的存储过程查询内存优化的表时，此项将始终为 0。", "查询自上次编译以来已执行计划的次数所返回的最小行数。不可为 null。,当本机编译的存储过程查询内存优化的表时，此项将始终为 0。", "查询自上次编译以来已执行计划的次数所返回的最大行数。不可为 null。,当本机编译的存储过程查询内存优化的表时，此项将始终为 0", " " };
            }
        }

        /*
                /// <summary>
                /// 根据设置的主键，获得实体的表入口,并且给各个属性赋值，注意：WhereSql,JoinSql对该方法无用
                /// </summary>
                /// <param name="WEBMANAGER_NAME"></param>
        /// <param name="SQL_MD5"> </param>
                /// <returns>bool</returns>
                public bool Find(string P_WEBMANAGER_NAME,string P_SQL_MD5)
                {
                    bool Value=false;
                    this.ColumnValues[0]=P_WEBMANAGER_NAME;
        this.ColumnValues[1]=P_SQL_MD5;
                    if(this.SelectTop1()!=null)
                        Value=true;
                    return Value;
                }
        */

        /*		
                /// <summary>
                /// 深度拷贝DATABASE_SQL_MY_IGNORE（新开辟了内存空间）
                /// </summary>
                /// <returns></returns>
                public DATABASE_SQL_MY_IGNORE Copy()
                {
                    DATABASE_SQL_MY_IGNORE new_obj=new DATABASE_SQL_MY_IGNORE();
                    base.CopyObj(new_obj);
                    int columnindex=0;
                    foreach (string column in this.Columns)
                    {
                        new_obj.SetColumnValue(column, this[column],columnindex);
                        columnindex++;
                    }
                    return new_obj;
                }
        */
        #endregion
        #region 实现关联Join方法和属性

        private bool inner_join_admin_webmanager = false;
        private bool left_join_admin_webmanager = false;

        /// <summary>
        /// INNER JOIN ADMIN_WEBMANAGER ADMIN_WEBMANAGER  ON ADMIN_WEBMANAGER.WEBMANAGER_NAME=DATABASE_SQL_MY.WEBMANAGER_NAME
        /// </summary>
        public bool INNER_JOIN_ADMIN_WEBMANAGER
        {
            set
            {
                this.inner_join_admin_webmanager = value;
            }
        }
        /// <summary>
        /// LEFT OUTER JOIN ADMIN_WEBMANAGER ADMIN_WEBMANAGER  ON ADMIN_WEBMANAGER.WEBMANAGER_NAME=DATABASE_SQL_MY.WEBMANAGER_NAME
        /// </summary>
        public bool LEFT_JOIN_ADMIN_WEBMANAGER
        {
            set
            {
                this.left_join_admin_webmanager = value;
            }
        }

        /// <summary>
        /// 根据关联设置
        /// INNER_JOIN_ADMIN_WEBMANAGER
        /// LEFT_JOIN_ADMIN_WEBMANAGER

        /// 为基类查询语句设置关联表JoinTableList
        /// </summary>
        protected override void SetJoinValues()
        {
            this.JoinTableListOnInit();
            this.JoinTableList.Rows.Clear();
            if (this.inner_join_admin_webmanager == true)
            {
                this.NewJoin("TEAMTOOL", "INNER", "ADMIN_WEBMANAGER", "ADMIN_WEBMANAGER", "WEBMANAGER_NAME", "WEBMANAGER_NAME");
            }
            if (this.left_join_admin_webmanager == true)
            {
                this.NewJoin("TEAMTOOL", "LEFT OUTER", "ADMIN_WEBMANAGER", "ADMIN_WEBMANAGER", "WEBMANAGER_NAME", "WEBMANAGER_NAME");
            }

            this.JoinTableList.AcceptChanges();
        }

        #endregion
        #endregion 系统代码，请不要动

        #region 数据库表生成SQL
        /*
                 				
                CREATE TABLE [dbo].[DATABASE_SQL_MY_IGNORE](
                 [WEBMANAGER_NAME] [VARCHAR]  (50)  COLLATE Chinese_PRC_CI_AS  NOT NULL ,
                 [SQL_MD5] [VARCHAR]  (50)  COLLATE Chinese_PRC_CI_AS  NOT NULL ,
                 [SOURCE_MD5] [VARCHAR]  (50)  COLLATE Chinese_PRC_CI_AS  NULL ,
                 [SQL_ERROR] [NVARCHAR]  (2000)  COLLATE Chinese_PRC_CI_AS  NULL ,
                 [TEXT_ANALYSIS] [VARCHAR]  (-1)  COLLATE Chinese_PRC_CI_AS  NULL ,
                 [DATABASE_IP] [VARCHAR]  (50)  COLLATE Chinese_PRC_CI_AS  NULL ,
                 [DATABASE_USER] [VARCHAR]  (100)  COLLATE Chinese_PRC_CI_AS  NULL ,
                 [DATABASE_NAME] [VARCHAR]  (50)  COLLATE Chinese_PRC_CI_AS  NULL ,
                 [TABLE_NAME] [VARCHAR]  (50)  COLLATE Chinese_PRC_CI_AS  NULL ,
                 [CREATION_TIME] [DATETIME]  NULL ,
                 [LAST_EXECUTION_TIME] [DATETIME]  NULL ,
                 [EXECUTION_COUNT] [BIGINT]  NULL ,
                 [TOTAL_WORKER_TIME] [BIGINT]  NULL ,
                 [LAST_WORKER_TIME] [BIGINT]  NULL ,
                 [MIN_WORKER_TIME] [BIGINT]  NULL ,
                 [MAX_WORKER_TIME] [BIGINT]  NULL ,
                 [TOTAL_PHYSICAL_READS] [BIGINT]  NULL ,
                 [LAST_PHYSICAL_READS] [BIGINT]  NULL ,
                 [MIN_PHYSICAL_READS] [BIGINT]  NULL ,
                 [MAX_PHYSICAL_READS] [BIGINT]  NULL ,
                 [TOTAL_LOGICAL_WRITES] [BIGINT]  NULL ,
                 [LAST_LOGICAL_WRITES] [BIGINT]  NULL ,
                 [MIN_LOGICAL_WRITES] [BIGINT]  NULL ,
                 [MAX_LOGICAL_WRITES] [BIGINT]  NULL ,
                 [TOTAL_LOGICAL_READS] [BIGINT]  NULL ,
                 [LAST_LOGICAL_READS] [BIGINT]  NULL ,
                 [MIN_LOGICAL_READS] [BIGINT]  NULL ,
                 [MAX_LOGICAL_READS] [BIGINT]  NULL ,
                 [TOTAL_ELAPSED_TIME] [BIGINT]  NULL ,
                 [LAST_ELAPSED_TIME] [BIGINT]  NULL ,
                 [MIN_ELAPSED_TIME] [BIGINT]  NULL ,
                 [MAX_ELAPSED_TIME] [BIGINT]  NULL ,
                 [TOTAL_ROWS] [BIGINT]  NULL ,
                 [LAST_ROWS] [BIGINT]  NULL ,
                 [MIN_ROWS] [BIGINT]  NULL ,
                 [MAX_ROWS] [BIGINT]  NULL ,
                 [CREATETIME] [DATETIME]  NULL  CONSTRAINT [DF_DATABASE_SQL_MY_IGNORE_CREATETIME] DEFAULT ('getdate') ,
                
                CONSTRAINT [PK_DATABASE_SQL_MY_IGNORE] PRIMARY KEY CLUSTERED 
                (
	             [WEBMANAGER_NAME] ASC,[SQL_MD5] ASC
                )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]

                ) ON [PRIMARY]
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'来源出处的MD5加密串，包括url和命名空间、函数、SQL参数等信息' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'SOURCE_MD5'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数据库IP' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'DATABASE_IP'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数据库用户' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'DATABASE_USER'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'编译计划的时间。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'CREATION_TIME'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'上次开始执行计划的时间。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'LAST_EXECUTION_TIME'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'计划自上次编译以来所执行的次数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'EXECUTION_COUNT'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'此计划自编译以来执行所用的 CPU 时间总量（以微秒为单位报告，但仅精确到毫秒）。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'TOTAL_WORKER_TIME'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'上次执行计划所用的 CPU 时间（以微秒为单位报告，但仅精确到毫秒）。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'LAST_WORKER_TIME'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'此计划在单次执行期间所用的最小 CPU 时间（以微秒为单位报告，但仅精确到毫秒）。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'MIN_WORKER_TIME'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'此计划在单次执行期间所用的最大 CPU 时间（以微秒为单位报告，但仅精确到毫秒）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'MAX_WORKER_TIME'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'此计划自编译后在执行期间所执行的物理读取总次数。
当查询内存优化的表时，此项将始终为 0。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'TOTAL_PHYSICAL_READS'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'上次执行计划时所执行的物理读取次数。
当查询内存优化的表时，此项将始终为 0。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'LAST_PHYSICAL_READS'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'此计划在单个执行期间所执行的最少物理读取次数。
当查询内存优化的表时，此项将始终为 0。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'MIN_PHYSICAL_READS'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'此计划在单个执行期间所执行的最多物理读取次数。
当查询内存优化的表时，此项将始终为 0。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'MAX_PHYSICAL_READS'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'此计划自编译后在执行期间所执行的逻辑写入总次数。
当查询内存优化的表时，此项将始终为 0。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'TOTAL_LOGICAL_WRITES'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'上次执行计划时变脏的缓冲池页数。如果页已变脏（已修改），则不计入写次数。
当查询内存优化的表时，此项将始终为 0。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'LAST_LOGICAL_WRITES'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'此计划在单个执行期间所执行的最少逻辑写入次数。
当查询内存优化的表时，此项将始终为 0。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'MIN_LOGICAL_WRITES'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'此计划在单个执行期间所执行的最多逻辑写入次数。
当查询内存优化的表时，此项将始终为 0。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'MAX_LOGICAL_WRITES'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'此计划自编译后在执行期间所执行的逻辑读取总次数。
当查询内存优化的表时，此项将始终为 0。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'TOTAL_LOGICAL_READS'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'上次执行计划时所执行的逻辑读取次数。
当查询内存优化的表时，此项将始终为 0。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'LAST_LOGICAL_READS'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'此计划在单个执行期间所执行的最少逻辑读取次数。
当查询内存优化的表时，此项将始终为 0。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'MIN_LOGICAL_READS'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'此计划在单个执行期间所执行的最多逻辑读取次数。
当查询内存优化的表时，此项将始终为 0。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'MAX_LOGICAL_READS'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'上次完成执行此计划所用的总时间（以微秒为单位报告，但仅精确到毫秒）。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'TOTAL_ELAPSED_TIME'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最近一次完成执行此计划所用的时间（以微秒为单位报告，但仅精确到毫秒）。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'LAST_ELAPSED_TIME'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'任何一次完成执行此计划所用的最小时间（以微秒为单位报告，但仅精确到毫秒）。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'MIN_ELAPSED_TIME'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'任何一次完成执行此计划所用的最大时间（以微秒为单位报告，但仅精确到毫秒）。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'MAX_ELAPSED_TIME'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'查询返回的总行数。不可为 null。
当本机编译的存储过程查询内存优化的表时，此项将始终为 0。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'TOTAL_ROWS'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'上一次执行查询返回的行数。不可为 null。
当本机编译的存储过程查询内存优化的表时，此项将始终为 0。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'LAST_ROWS'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'查询自上次编译以来已执行计划的次数所返回的最小行数。不可为 null。
当本机编译的存储过程查询内存优化的表时，此项将始终为 0。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'MIN_ROWS'
                GO

                EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'查询自上次编译以来已执行计划的次数所返回的最大行数。不可为 null。
当本机编译的存储过程查询内存优化的表时，此项将始终为 0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'DATABASE_SQL_MY_IGNORE', @level2type=N'COLUMN',@level2name=N'MAX_ROWS'
                GO


                */
        #endregion

        #region 在此处添加用户自己的业务逻辑代码
        //在此处添加用户自己的业务逻辑代码
        #endregion
    }
}