using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BiotyposV1.Models
{
	public class MedicalCenterPhone
	{
		#region ModelAttributes
		//primary key
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		//Telephone of Medical Center
		[Required(ErrorMessage = "Please insert Medical Center's Phone Number.")]
		[Display(Name = "Phone Number")]
		[DataType(DataType.PhoneNumber)]
		public string Number { get; set; }

		#endregion ModelAttributes

		#region ForeignKeys
		//foreign key connection to Medical Center
		[ForeignKey("MedicalCenter")]
		[DefaultValue(0)]
		public int MedicalCenterRefId { get; set; }
		public MedicalCenter MedicalCenter { get; set; }
		#endregion ForeignKeys
	}
}