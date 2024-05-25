﻿using BE_ABC.Models.CommonModels;
using BE_ABC.Models.DTO.Request;
using BE_ABC.Models.ErdModel;
using BE_ABC.Services;
using Microsoft.AspNetCore.Mvc;

namespace BE_ABC.Controllers
{

    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class DepartmentController : Controller
    {
        private readonly DepartmentService DepartmentService;
        public DepartmentController(DepartmentService DepartmentService)
        {
            this.DepartmentService = DepartmentService;
        }
        [HttpPost]
        [Route("getAll")]
        public IActionResult getAll(Pagination pagination)
        {
            try
            {
                return Ok(DepartmentService.getAll(pagination));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> insert(List<DepartmentReq> ptReq)
        {
            try
            {
                foreach (var req in ptReq)
                {
                    var (check, err) = await DepartmentService.checkInsert(req);
                    if (!check)
                    {
                        return BadRequest(err);
                    }
                }

                var listInsertedUser = new List<Department>();
                foreach (var req in ptReq)
                {
                    var entity = await DepartmentService.insert(req);
                    listInsertedUser.Add(entity);
                }

                return Ok(listInsertedUser);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("")]
        public async Task<IActionResult> update(List<Department> pt)
        {
            try
            {
                //foreach (var req in user)
                //{
                //    var (check, err) = await DepartmentService.check(req);
                //    if (!check)
                //    {
                //        return BadRequest(err);
                //    }
                //}

                foreach (var req in pt)
                {
                    await DepartmentService.update(req);
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("")]
        public async Task<IActionResult> hardDelete(List<int> uid)
        {
            try
            {
                foreach (var req in uid)
                {
                    var find = await DepartmentService.FindByIdAsync(req);
                    if (find != null)
                        await DepartmentService.DeleteAsync(find);
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
