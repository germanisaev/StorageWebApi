using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExamWebApi.Application.Domain.StorageProject;
using ExamWebApi.Models.Storages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExamWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StorageProjectController : ControllerBase
    {
        private readonly ILogger<StorageProjectController> _logger;
        private readonly IStorageProjectService _service;

        public StorageProjectController(ILogger<StorageProjectController> logger, IStorageProjectService service)
        {
            _logger = logger;
            _service = service;
        }

        [Route("/api/storageproject/storage/all")]
        [HttpGet]
        public async Task<IActionResult> GetAllStorages()
        {
            IEnumerable<StorageDTO> storageDetails = null;
            
            try {
                storageDetails = await _service.GetAllStorages();
            }
            catch(Exception ex) {
                _logger.LogError(ex, "StorageProjectService.GetAllStorages encountered an exception.");
                return StatusCode(500 ,ex.Message);
            }
            return Ok(storageDetails);
        }

        [Route("/api/storageproject/storage/{storageId}")]
        [HttpGet]
        public async Task<IActionResult> GetStorageBy([FromRoute] string storageId = null)
        {
            StorageDTO storageDetails = null;

            try {
                storageDetails = await _service.GetStorageBy(storageId);
                if (storageDetails == null)
                {
                    return NotFound();
                }
            }
            catch(Exception ex) {
                _logger.LogError(ex, "StorageProjectService.GetStorageBy encountered an exception.");
                return StatusCode(500 ,ex.Message);
            }
            return Ok(storageDetails);
        }
    }
}