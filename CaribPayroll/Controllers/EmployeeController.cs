﻿using System;
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
using Microsoft.EntityFrameworkCore;

namespace CaribPayroll.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger _logger;
        private readonly IDateTimeUtc _dateTime;

        public EmployeeController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, ILogger<EmployeeController> logger, IDateTimeUtc dateTimeUtc)
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

            //IEnumerable data = _context.Employees.Include(data => data.EmployeeAddress) ;
            IEnumerable data = _context.Employees.Include(data => data.EmployeeAddress)
                .Select(e => new EmployeeWithAddressListViewModel() { 
                    Id = e.Id,
                    EmployeeNo = e.EmployeeNo,
                    Surname = e.Surname,
                    FirstName = e.FirstName,
                    MiddleName = e.MiddleName,
                    NationalRegistrationNo = e.NationalRegistrationNo,
                    PaymentPeriodId = e.PaymentPeriodId,
                    DepartmentId = e.DepartmentId,
                    AddressLine1 = e.EmployeeAddress.AddressLine1,
                    AddressLine2 = e.EmployeeAddress.AddressLine2,
                    ParishId = e.EmployeeAddress.ParishId,
                    DistrictId = e.EmployeeAddress.DistrictId
                });

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

            int count = data.Cast<EmployeeWithAddressListViewModel>().Count();
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

            selectedFields = new List<string> { "Id", "EmployeeNo", "Surname", "FirstName", "MiddleName", "NationalRegistrationNo", "PaymentPeriodId", "DepartmentId", "AddressLine1", "AddressLine2", "ParishId", "DistrictId" };

            data = operation.PerformSelect(data, selectedFields);

        

            return Json(new { result = data, count = count });
        }

        public ActionResult Insert([FromBody]CRUDModel<EmployeeWithAddressListViewModel> viewModel)
        {
            Employee newEmployee = new Employee();
            newEmployee.EmployeeAddress = new EmployeeAddress();

            newEmployee.EmployeeNo = viewModel.Value.EmployeeNo;
            newEmployee.Surname = viewModel.Value.Surname;
            newEmployee.FirstName = viewModel.Value.FirstName;
            newEmployee.MiddleName = viewModel.Value.MiddleName;
            newEmployee.NationalRegistrationNo = viewModel.Value.NationalRegistrationNo;
            newEmployee.PaymentPeriodId = viewModel.Value.PaymentPeriodId;
            newEmployee.DepartmentId = viewModel.Value.DepartmentId;

            newEmployee.EmployeeAddress.AddressLine1 = viewModel.Value.AddressLine1;
            newEmployee.EmployeeAddress.AddressLine2 = viewModel.Value.AddressLine2;
            newEmployee.EmployeeAddress.ParishId = viewModel.Value.ParishId;
            newEmployee.EmployeeAddress.DistrictId = viewModel.Value.DistrictId;

            newEmployee.Action = RecordActions.AddAction;
            newEmployee.CreatedDate = _dateTime.Now;
            newEmployee.CreatedBy = _userManager.GetUserName(User);
            newEmployee.EmployeeAddress.Action = RecordActions.AddAction;
            newEmployee.EmployeeAddress.CreatedDate = _dateTime.Now;
            newEmployee.EmployeeAddress.CreatedBy = _userManager.GetUserName(User);

            //newEmployee.EmployeeAddress.Employee = newEmployee;

            try
            {
                _context.Employees.Add(newEmployee);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggingEvents.TableConfiguration, LoggingErrorText.editTableFailed, "Employee", _userManager.GetUserName(User), ex.Message);
            }
            return Json(viewModel.Value);
        }

        public ActionResult Update([FromBody]CRUDModel<EmployeeWithAddressListViewModel> viewModel)
        {
            try
            {
                var retrievedRecord = _context.Employees.Include(retrievedRecord => retrievedRecord.EmployeeAddress).Where(r => r.Id == viewModel.Value.Id).FirstOrDefault();
                retrievedRecord.EmployeeNo = viewModel.Value.EmployeeNo;
                retrievedRecord.Surname = viewModel.Value.Surname;
                retrievedRecord.FirstName = viewModel.Value.FirstName;
                retrievedRecord.MiddleName = viewModel.Value.MiddleName;
                retrievedRecord.NationalRegistrationNo = viewModel.Value.NationalRegistrationNo;
                retrievedRecord.PaymentPeriodId = viewModel.Value.PaymentPeriodId;
                retrievedRecord.DepartmentId = viewModel.Value.DepartmentId;
                retrievedRecord.EmployeeAddress.AddressLine1 = viewModel.Value.AddressLine1;
                retrievedRecord.EmployeeAddress.AddressLine2 = viewModel.Value.AddressLine2;
                retrievedRecord.EmployeeAddress.ParishId = viewModel.Value.ParishId;
                retrievedRecord.EmployeeAddress.DistrictId = viewModel.Value.DistrictId;

                retrievedRecord.Action = RecordActions.ModifyAction;
                retrievedRecord.ModifiedDate = _dateTime.Now;
                retrievedRecord.ModifiedBy = _userManager.GetUserName(User);
                retrievedRecord.EmployeeAddress.Action = RecordActions.ModifyAction;
                retrievedRecord.EmployeeAddress.ModifiedDate = _dateTime.Now;
                retrievedRecord.EmployeeAddress.ModifiedBy = _userManager.GetUserName(User);


                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggingEvents.TableConfiguration, LoggingErrorText.editTableFailed, "Employee", _userManager.GetUserName(User), ex.Message);
            }

            return Json(viewModel.Value);
        }


        public ActionResult Delete([FromBody]CRUDModel<EmployeeWithAddressListViewModel> viewModel)
        {
            string employeeDetails = "";
            try
            {
                var retrievedRecord = _context.Employees.Include(retrievedRecord => retrievedRecord.EmployeeAddress).Where(r => r.Id == Convert.ToInt32(viewModel.Key)).FirstOrDefault();
                if (retrievedRecord != null)
                {
                    employeeDetails = string.Format("Employee No {0}, Surname {1}, First name {2}, Middle name {3}, National Registration No {4}, Payment Period Id {5}, Department Id {6}, Address Line 1 {7}, Address Line 2 {8}, Parish Id {9}, District Id {10}, Created By {11}, Created Date {12}, Modified By {13}, Modified Date {14}",
                     retrievedRecord.EmployeeNo, retrievedRecord.Surname, retrievedRecord.FirstName, retrievedRecord.MiddleName, retrievedRecord.NationalRegistrationNo, retrievedRecord.PaymentPeriodId, retrievedRecord.DepartmentId, retrievedRecord.EmployeeAddress.AddressLine1, retrievedRecord.EmployeeAddress.AddressLine2,
                     retrievedRecord.EmployeeAddress.ParishId, retrievedRecord.EmployeeAddress.DistrictId, retrievedRecord.CreatedBy, retrievedRecord.CreatedDate.ToString(), retrievedRecord.ModifiedBy, retrievedRecord.ModifiedDate.ToString());

                    _context.Employees.Remove(retrievedRecord);
                    _context.SaveChanges();
                    _logger.LogWarning(LoggingEvents.TableConfiguration, LoggingErrorText.deleteTableSucceed, "Employee", employeeDetails, _userManager.GetUserName(User));
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(LoggingEvents.TableConfiguration, LoggingErrorText.deleteTableFailed, "Employee", employeeDetails, _userManager.GetUserName(User), ex.Message);
            }
            return Json(viewModel.Value);
        }


    }
}