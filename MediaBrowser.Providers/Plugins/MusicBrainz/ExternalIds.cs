using MediaBrowser.Controller.Entities.Audio;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;
using MediaBrowser.Providers.Plugins.MusicBrainz;

namespace MediaBrowser.Providers.Music
{
    public class MusicBrainzReleaseGroupExternalId : IExternalId
    {
        /// <inheritdoc />
        public string Name => "MusicBrainz";

        /// <inheritdoc />
        public string Key => MetadataProviders.MusicBrainzReleaseGroup.ToString();

        /// <inheritdoc />
        public ExternalIdMediaType Type => ExternalIdMediaType.ReleaseGroup;

        /// <inheritdoc />
        public string UrlFormatString => Plugin.Instance.Configuration.Server + "/release-group/{0}";

        /// <inheritdoc />
        public bool Supports(IHasProviderIds item) => item is Audio || item is MusicAlbum;
    }

    public class MusicBrainzAlbumArtistExternalId : IExternalId
    {
        /// <inheritdoc />
        public string Name => "MusicBrainz";

        /// <inheritdoc />
        public string Key => MetadataProviders.MusicBrainzAlbumArtist.ToString();

        /// <inheritdoc />
        public ExternalIdMediaType Type => ExternalIdMediaType.AlbumArtist;

        /// <inheritdoc />
        public string UrlFormatString => Plugin.Instance.Configuration.Server + "/artist/{0}";

        /// <inheritdoc />
        public bool Supports(IHasProviderIds item) => item is Audio;
    }

    public class MusicBrainzAlbumExternalId : IExternalId
    {
        /// <inheritdoc />
        public string Name => "MusicBrainz";

        /// <inheritdoc />
        public string Key => MetadataProviders.MusicBrainzAlbum.ToString();

        /// <inheritdoc />
        public ExternalIdMediaType Type => ExternalIdMediaType.Album;

        /// <inheritdoc />
        public string UrlFormatString => Plugin.Instance.Configuration.Server + "/release/{0}";

        /// <inheritdoc />
        public bool Supports(IHasProviderIds item) => item is Audio || item is MusicAlbum;
    }

    public class MusicBrainzArtistExternalId : IExternalId
    {
        /// <inheritdoc />
        public string Name => "MusicBrainz";

        /// <inheritdoc />
        public string Key => MetadataProviders.MusicBrainzArtist.ToString();

        /// <inheritdoc />
        public ExternalIdMediaType Type => ExternalIdMediaType.Artist;

        /// <inheritdoc />
        public string UrlFormatString => Plugin.Instance.Configuration.Server + "/artist/{0}";

        /// <inheritdoc />
        public bool Supports(IHasProviderIds item) => item is MusicArtist;
    }

    public class MusicBrainzOtherArtistExternalId : IExternalId
    {
        /// <inheritdoc />
        public string Name => "MusicBrainz";

        /// <inheritdoc />

        public string Key => MetadataProviders.MusicBrainzArtist.ToString();

        /// <inheritdoc />
        public ExternalIdMediaType Type => ExternalIdMediaType.OtherArtist;

        /// <inheritdoc />
        public string UrlFormatString => Plugin.Instance.Configuration.Server + "/artist/{0}";

        /// <inheritdoc />
        public bool Supports(IHasProviderIds item) => item is Audio || item is MusicAlbum;
    }

    public class MusicBrainzTrackId : IExternalId
    {
        /// <inheritdoc />
        public string Name => "MusicBrainz";

        /// <inheritdoc />
        public string Key => MetadataProviders.MusicBrainzTrack.ToString();

        /// <inheritdoc />
        public ExternalIdMediaType Type => ExternalIdMediaType.Track;

        /// <inheritdoc />
        public string UrlFormatString => Plugin.Instance.Configuration.Server + "/track/{0}";

        /// <inheritdoc />
        public bool Supports(IHasProviderIds item) => item is Audio;
    }
}
