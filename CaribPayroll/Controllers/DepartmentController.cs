using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaribPayroll.Constants;
using CaribPayroll.Data;
using CaribPayroll.Helpers;
using CaribPayroll.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Syncfusion.EJ2.Base;

namespace CaribPayroll.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger _logger;
        private readonly IDateTimeUtc _dateTime;

        public DepartmentController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, ILogger<DepartmentController> logger, IDateTimeUtc dateTimeUtc)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
            _dateTime = dateTimeUtc;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult DataSource([FromBody]DataManagerRequest dm)
        {

            IEnumerable data = _context.Departments;
            DataOperations operation = new DataOperations();

            if (dm.Search != null && dm.Search.Count > 0) //Sorting 
            {
                data = operation.PerformSearching(data, dm.Search);
            }

            if (dm.Sorted != null && dm.Sorted.Count > 0) //Sorting 
            {
                data = operation.PerformSorting(data, dm.Sorted);
            }
            if (dm.Where != null && dm.Where.Count > 0) //Filtering 
            {
                data = operation.PerformFiltering(data, dm.Where, dm.Where[0].Operator);
            }

            int count = data.Cast<Department>().Count();
            if (dm.Skip != 0)  //paging 
            {
                data = operation.PerformSkip(data, dm.Skip);
            }
            if (dm.Take != 0)
            {
                data = operation.PerformTake(data, dm.Take);
            }
            //select only the fields required for the view

            List<string> selectedFields = new List<string> { };

            selectedFields = new List<string> { "Id", "Description", "GLCode" };

            data = operation.PerformSelect(data, selectedFields);

            return Json(new { result = data, count = count });
        }

        public ActionResult Update([FromBody]CRUDModel<DepartmentListViewModel> viewModel)
        {
            try
            {
                var retrievedRecord = _context.Departments.Where(r => r.Id == viewModel.Value.Id).FirstOrDefault();
                retrievedRecord.Description = viewModel.Value.Description;
                retrievedRecord.GLCode = viewModel.Value.GLCode;
                retrievedRecord.Action = RecordActions.ModifyAction;
                retrievedRecord.ModifiedDate = _dateTime.Now;
                retrievedRecord.ModifiedBy = _userManager.GetUserName(User);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggingEvents.TableConfiguration, LoggingErrorText.editTableFailed, "Department", _userManager.GetUserName(User), ex.Message);
            }
            return Json(viewModel.Value);
        }

        public ActionResult Insert([FromBody]CRUDModel<DepartmentListViewModel> viewModel)
        {
            Department newDepartment = new Department();
            newDepartment.Description = viewModel.Value.Description;
            newDepartment.GLCode = viewModel.Value.GLCode;
            newDepartment.Action = RecordActions.AddAction;
            newDepartment.CreatedDate = _dateTime.Now;
            newDepartment.CreatedBy = _userManager.GetUserName(User);

            try
            {
                _context.Departments.Add(newDepartment);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggingEvents.TableConfiguration, LoggingErrorText.editTableFailed, "Department", _userManager.GetUserName(User), ex.Message);
            }
            return Json(viewModel.Value);
        }

        public ActionResult Delete([FromBody]CRUDModel<DepartmentListViewModel> viewModel)
        {
            string tableDetails = "";
            try
            {
                Department retrievedRecord = _context.Departments.Where(r => r.Id == Convert.ToInt32(viewModel.Key)).FirstOrDefault();
                if (retrievedRecord != null)
                {
                    tableDetails = string.Format("Department {0}, GLCode {1} Created By {2}, Created Date {3}, Modified By {4}, Modified Date {5}",
                     retrievedRecord.Description, retrievedRecord.GLCode, retrievedRecord.CreatedBy, retrievedRecord.CreatedDate.ToString(), retrievedRecord.ModifiedBy, retrievedRecord.ModifiedDate.ToString());

                    _context.Departments.Remove(retrievedRecord);
                    _context.SaveChanges();
                    _logger.LogWarning(LoggingEvents.TableConfiguration, LoggingErrorText.deleteTableSucceed, "Department", tableDetails, _userManager.GetUserName(User));
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggingEvents.TableConfiguration, LoggingErrorText.deleteTableFailed, "Department", tableDetails, _userManager.GetUserName(User), ex.Message);
            }

            return Json(viewModel.Value);
        }

    }
}