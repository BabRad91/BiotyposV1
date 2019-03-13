using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BiotyposV1.Models;

namespace BiotyposV1.ViewModels
{
	public class NavBarViewModel
	{
		public IEnumerable<MedicalCenter> MedicalCenters { get; set; }
		public class MedicalCenter
		{
			#region ModelAttributes
			//primary key
			[Key]
			[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
			public int Id { get; set; }

			//Name of Medical Center
			[Required(ErrorMessage = "Please insert Medical Center's name.")]
			[StringLength(255)]
			[Display(Name = "Name")]
			public string Name { get; set; }
			#endregion ModelAttributes
		}
	}
}