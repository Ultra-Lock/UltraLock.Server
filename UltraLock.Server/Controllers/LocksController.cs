using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UltraLock.Server.Helper;
using UltraLock.Server.Model;

namespace UltraLock.Server.Controllers
{
    [Route(Startup.ApiVersion + "/[controller]")]
    [ApiController]
    public class LocksController : ControllerBase
    {
        [HttpGet]
        public Task<ActionResult<LockOutListDto>> GetLockList()
        {
            return Ok();
        }

        [HttpGet("{lockId}")]
        public Task<ActionResult<LockOutSingleDto>> GetLock([FromRoute] Guid lockGuid)
        {
            return Ok();
        }

        [HttpPut("{lockId}")]
        public Task<ActionResult<LockOutSingleDto>> UpdateLock([FromRoute] Guid lockGuid, [FromBody] LockInUpdateDto lockDto)
        {
            return Ok();
        }

        [HttpPut("{lockId}/Status")]
        public Task<ActionResult<LockOutSingleDto>> UpdateLockStatus([FromRoute] Guid lockGuid, [FromBody] LockStatus lockStatus)
        {

            return Ok();
        }

        [HttpDelete("{lockId}")]
        public Task<IActionResult> DeleteLock([FromRoute] Guid lockGuid)
        {
            return Ok();
        }
    }
}
