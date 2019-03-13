using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BiotyposV1.Models;

namespace BiotyposV1.Controllers
{
	public class MedicalCentersController : Controller
	{
		#region SetMedCentToBeUsedWithDB
		private ApplicationDbContext _context;

		public MedicalCentersController()
		{
			_context = new ApplicationDbContext();
		}

		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}
		#endregion SetMedCentToBeUsedWithDB

		#region MedicalCenterNavBar
		[ChildActionOnly]
		public ActionResult NavBar()
		{
			IEnumerable<MedicalCenter> medicalCenters;
			{
				medicalCenters = _context.MedicalCenters.ToList();
			}

			return PartialView("_MedicalCenters", medicalCenters);
		}
		#endregion MedicalCenterNavBar


		#region ViewSpecificMedicalCenter
		public ActionResult Details(int id)
		{
			var medcent = _context.MedicalCenters.SingleOrDefault(referObject => referObject.Id == id);
			if (medcent == null)
				return HttpNotFound();

			return View(medcent);
		}
		#endregion ViewSpecificMedicalCenter


		#region ManageMedicalCenterEntries
		public ViewResult Manage()
		{
			var medcent = _context.MedicalCenters;

			return View(medcent.ToList());
		}
		#endregion ManageMedicalCenterEntries
	}
}