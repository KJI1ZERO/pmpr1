//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zapis_
    {
        public int id_zapisi { get; set; }
        public int id_Client { get; set; }
        public int id_price_list { get; set; }
        public int id_Yslygi1 { get; set; }
        public int id_zala { get; set; }
        public int id_rabotnica { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Price_list Price_list { get; set; }
        public virtual Rabotnik Rabotnik { get; set; }
        public virtual Yslygi1 Yslygi1 { get; set; }
        public virtual zal zal { get; set; }
    }
}