//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hado.DL
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class QuestionAnswer
    {
        [DataMember]
        public int QAId { get; set; }
        [DataMember]
        public Nullable<int> QuestionId { get; set; }
        [DataMember]
        public string QuestionAnswers { get; set; }
    }
}