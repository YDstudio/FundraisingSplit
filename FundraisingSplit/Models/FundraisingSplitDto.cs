using System;
using System.Collections.Generic;
using FundraisingSplit.Enums;

namespace FundraisingSplit.Models
{
  public class FundraisingSplitDto
  {
    /// <summary>
    /// 序號
    /// </summary>
    /// <value></value>
    public int Id{get;set;}

    /// <summary>
    /// 集資專案名稱
    /// </summary>
    /// <value></value>
    public string Name {get;set;}

    /// <summary>
    ///  集資目標金額
    /// </summary>
    /// <value></value>
    public decimal TotalAmount {get;set;}

    /// <summary>
    /// 集資起始時間
    /// </summary>
    /// <value></value>
    public DateTime StartDt {get;set;}

    /// <summary>
    ///  集資結束時間 （可不設定結束時間）
    /// </summary>
    /// <value></value>
    public DateTime? EndDt{get;set;}

    /// <summary>
    /// 參與者
    /// </summary>
    /// <value></value>
    public List<MemberDto> Members {get;set;}
    
    /// <summary>
    ///  集資類型
    /// </summary>
    /// <value></value>
    public EnumFundraisingType Type {get;set;}
  }
}
