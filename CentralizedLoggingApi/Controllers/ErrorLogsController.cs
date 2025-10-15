﻿using CentralizedLoggingApi.Data;
using CentralizedLoggingApi.DTO;
using CentralizedLoggingApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CentralizedLogging.Contracts.Models;
using CentralizedLogging.Contracts.DTO;

namespace CentralizedLoggingApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ErrorLogsController : ControllerBase
    {
        private readonly LoggingDbContext _context;

        public ErrorLogsController(LoggingDbContext context)
        {
            _context = context;
        }
                
        // POST api/errorlogs
        [HttpPost]
        public async Task<IActionResult> LogError([FromBody] CreateErrorLogDto errorLogDto)
        {
            if (errorLogDto == null)
                return BadRequest("Error log cannot be null");

            // Ensure LoggedAt is set
            
            var errorLog = new ErrorLog
            {
                ApplicationId = errorLogDto.ApplicationId,
                Severity = errorLogDto.Severity,
                Message = errorLogDto.Message,
                StackTrace = errorLogDto.StackTrace,
                Source = errorLogDto.Source,
                UserId = errorLogDto.UserId,
                RequestId = errorLogDto.RequestId,
                LoggedAt = DateTime.UtcNow // always use server UTC
            };

            _context.ErrorLogs.Add(errorLog);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetErrorById), new { id = errorLog.Id }, errorLog);
        }

        // GET api/errorlogs/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetErrorById(long id)
        {
            var error = await _context.ErrorLogs
                .Include(e => e.Application)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (error == null)
                return NotFound();

            return Ok(error);
        }

        [Authorize]
        // GET api/errorlogs
        [HttpGet]
        public async Task<IActionResult> GetAllErrors()
        {
            var logs = await _context.ErrorLogs
            .Include(e => e.Application)
            .Select(e => new GetAllErrorsResponseModel
            {
                Id = e.Id,
                Severity = e.Severity,
                Message = e.Message,
                StackTrace = e.StackTrace,
                Source = e.Source,
                UserId = e.UserId,
                RequestId = e.RequestId,
                LoggedAt = e.LoggedAt,
                ApplicationName = e.Application.Name   // navigation property
            })
            .ToListAsync();

            return Ok(logs);
        }
    }
}
