//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class ModTBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ModTBL()
        {
            this.CarTBLs = new HashSet<CarTBL>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string TopSpeedMod { get; set; }
        public string HorsepowerMod { get; set; }
        public string ZeroTo100Mod { get; set; }
        public string Index { get; set; }
        public string SetupName { get; set; }
        public string Type { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarTBL> CarTBLs { get; set; }
    }
}
