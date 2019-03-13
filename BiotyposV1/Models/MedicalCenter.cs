using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BiotyposV1.Models
{
	//[Table("MedicalCenter")]
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

		//Street Address of Medical Center
		[Required(ErrorMessage = "Please insert Medical Center's Street address.")]
		[StringLength(255)]
		[Display(Name = "Street")]
		public string Street { get; set; }

		//Street number of Medical Center
		[Required(ErrorMessage = "Please insert Medical Center's Street number.")]
		[RegularExpression("([0-9]+)", ErrorMessage = "Please use numbers only.")]
		[Display(Name = "Street Number")]
		[Range(1, int.MaxValue, ErrorMessage = "Please insert a value bigger than 0.")]
		public string StreetNumber { get; set; }

		//Region Address of Medical Center
		[Required(ErrorMessage = "Please insert Medical Center's Region address.")]
		[StringLength(255)]
		[Display(Name = "Region")]
		public string Region { get; set; }

		//City Address of Medical Center
		[Required(ErrorMessage = "Please insert Medical Center's City address.")]
		[StringLength(255)]
		[Display(Name = "City")]
		public string City { get; set; }

		//Zip code of Medical Center
		[Required(ErrorMessage = "Please insert Medical Center's Zip Code.")]
		[Display(Name = "Zip Code")]
		[Range(0, Int64.MaxValue, ErrorMessage = "Please use numbers only.")]
		[StringLength(5, MinimumLength = 5, ErrorMessage = "Zip code should have 5 digits")]
		public string ZipCode { get; set; }

		//Description of Medical Center
		[Required(ErrorMessage = "Please insert Medical Center's description.")]
		[Display(Name = "Description")]
		public string Description { get; set; }

		//GoogleMap of Medical Center
		[Required(ErrorMessage = "Please insert Medical Center's Google Maps Url.")]
		[DataType(DataType.Url)]
		public string GoogleMapUrl { get; set; }
		#endregion ModelAttributes

		#region ForeignKeyes
		//foreign key connection to Phones
		public virtual ICollection<MedicalCenterPhone> MedicalCenterPhone { get; set; }
		#endregion ForeignKeyes
	}
}