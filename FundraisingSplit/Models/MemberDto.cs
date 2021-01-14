using System;
using System.Data.SqlTypes;
using System.Reflection.PortableExecutable;

namespace FundraisingSplit.Models
{
  public class MemberDto
  {
    /// <summary>
    /// 序號
    /// </summary>
    /// <value></value>
    public int Id { get; set; }

    /// <summary>
    /// 名稱
    /// </summary>
    /// <value></value>
    public string Name { get; set; }

    /// <summary>
    /// 集資金額
    /// </summary>
    /// <value></value>
    public decimal PutAmount{get;set;}

    /// <summary>
    /// 集資時間
    /// </summary>
    /// <value></value>
    public DateTime UseDt {get;set;}
  }
}
