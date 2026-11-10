using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using YAGOT_2._0.Integration.SiteState;
using YAGOT_2._0.Models;

namespace YAGOT_2._0.Services.Integration;

public sealed class LocalSiteStateReader : ILocalSiteStateReader
{
    private readonly NeondbContext _context;
    private readonly SiteStateReconciliationOptions _options;

    public LocalSiteStateReader(
        NeondbContext context,
        IOptions<SiteStateReconciliationOptions> options)
    {
        _context = context;
        _options = options.Value;
    }

    public async Task<LocalSiteStateReadResult> ReadAsync(
        CancellationToken cancellationToken = default)
    {
        var entity = await _context.LocalSiteStateSnapshots
            .AsNoTracking()
            .SingleOrDefaultAsync(
                candidate => candidate.SiteId == _options.SiteId,
                cancellationToken);

        return entity is null
            ? LocalSiteStateReadResult.Missing
            : LocalSiteStateReadResult.Found(entity.ToContract());
    }
}
