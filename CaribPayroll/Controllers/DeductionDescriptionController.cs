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
    public class DeductionDescriptionController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger _logger;
        private readonly IDateTimeUtc _dateTime;

        public DeductionDescriptionController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, ILogger<DeductionDescriptionController> logger, IDateTimeUtc dateTimeUtc)
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

            IEnumerable data = _context.DeductionDescriptions;
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

            int count = data.Cast<DeductionDescription>().Count();
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

            selectedFields = new List<string> { "Id", "Description", "GLCode", "DeductionTypeId", "DeductionCalculationTypeId", "SubCategoriesExist" };

            data = operation.PerformSelect(data, selectedFields);

            return Json(new { result = data, count = count });
        }

        public ActionResult Update([FromBody]CRUDModel<DeductionDescriptionListViewModel> viewModel)
        {
            try
            {
                var retrievedRecord = _context.DeductionDescriptions.Where(r => r.Id == viewModel.Value.Id).FirstOrDefault();
                retrievedRecord.Description = viewModel.Value.Description;
                retrievedRecord.GLCode = viewModel.Value.GLCode;
                retrievedRecord.DeductionTypeId = viewModel.Value.DeductionTypeId;
                retrievedRecord.DeductionCalculationTypeId = viewModel.Value.DeductionCalculationTypeId;
                retrievedRecord.SubCategoriesExist = viewModel.Value.SubCategoriesExist;
                retrievedRecord.Action = RecordActions.ModifyAction;
                retrievedRecord.ModifiedDate = _dateTime.Now;
                retrievedRecord.ModifiedBy = _userManager.GetUserName(User);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggingEvents.TableConfiguration, LoggingErrorText.editTableFailed, "Deduction Description", _userManager.GetUserName(User), ex.Message);
            }
            return Json(viewModel.Value);
        }

        public ActionResult Insert([FromBody]CRUDModel<DeductionDescriptionListViewModel> viewModel)
        {
            DeductionDescription newDeductionDescription = new DeductionDescription();
            newDeductionDescription.Description = viewModel.Value.Description;
            newDeductionDescription.DeductionTypeId = viewModel.Value.DeductionTypeId;
            newDeductionDescription.DeductionCalculationTypeId = viewModel.Value.DeductionCalculationTypeId;
            newDeductionDescription.SubCategoriesExist = viewModel.Value.SubCategoriesExist;
            newDeductionDescription.Action = RecordActions.AddAction;
            newDeductionDescription.CreatedDate = _dateTime.Now;
            newDeductionDescription.CreatedBy = _userManager.GetUserName(User);

            try
            {
                _context.DeductionDescriptions.Add(newDeductionDescription);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggingEvents.TableConfiguration, LoggingErrorText.editTableFailed, "Deduction Description", _userManager.GetUserName(User), ex.Message);
            }
            return Json(viewModel.Value);
        }

        public ActionResult Delete([FromBody]CRUDModel<DeductionDescriptionListViewModel> viewModel)
        {
            string tableDetails = "";
            try
            {
                DeductionDescription retrievedRecord = _context.DeductionDescriptions.Where(r => r.Id == Convert.ToInt32(viewModel.Key)).FirstOrDefault();
                if (retrievedRecord != null)
                {
                    tableDetails = string.Format("Deduction Description {0}, GLCode {1}, DeductionTypeId {2}, DeductionCalculationTypeId {3}, Created By {4}, Created Date {5}, Modified By {6}, Modified Date {7}",
                     retrievedRecord.Description, retrievedRecord.GLCode, retrievedRecord.DeductionTypeId, retrievedRecord.DeductionCalculationTypeId, retrievedRecord.CreatedBy, retrievedRecord.CreatedDate.ToString(), retrievedRecord.ModifiedBy, retrievedRecord.ModifiedDate.ToString());

                    _context.DeductionDescriptions.Remove(retrievedRecord);
                    _context.SaveChanges();
                    _logger.LogWarning(LoggingEvents.TableConfiguration, LoggingErrorText.deleteTableSucceed, "Deduction Description", tableDetails, _userManager.GetUserName(User));
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggingEvents.TableConfiguration, LoggingErrorText.deleteTableFailed, "Deduction Description", tableDetails, _userManager.GetUserName(User), ex.Message);
            }

            return Json(viewModel.Value);
        }


    }
}