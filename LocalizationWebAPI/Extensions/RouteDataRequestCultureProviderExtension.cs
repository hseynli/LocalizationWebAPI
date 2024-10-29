using Microsoft.AspNetCore.Localization;

namespace LocalizationWebAPI
{
    public class RouteDataRequestCultureProvider : RequestCultureProvider
    {
        public int IndexOfCulture;
        public int IndexofUICulture;

        public override Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
        {
            ArgumentNullException.ThrowIfNull(httpContext);

            string? culture = null;
            string? uiCulture = null;

            culture = uiCulture = httpContext.Request.Path.Value.Split('/')[IndexOfCulture]?.ToString();

            var providerResultCulture = new ProviderCultureResult(culture, uiCulture);

            return Task.FromResult(providerResultCulture);
        }
    }
}
