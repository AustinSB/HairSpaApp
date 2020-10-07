namespace HairSpaApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Appointment
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public decimal Cost { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime StartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime EndTime { get; set; }

        public int EmployeesId { get; set; }

        public int CustomersId { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
