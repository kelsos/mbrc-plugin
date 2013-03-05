﻿using MusicBeePlugin.AndroidRemote.Commands;
using MusicBeePlugin.AndroidRemote.Commands.InstaReplies;
using MusicBeePlugin.AndroidRemote.Commands.Internal;
using MusicBeePlugin.AndroidRemote.Commands.Requests;
using MusicBeePlugin.AndroidRemote.Commands.State;

namespace MusicBeePlugin.AndroidRemote
{
    using Networking;
    using Events;

    internal class Configuration
    {
        public static void Register(Controller.Controller controller)
        {
            controller.AddCommand(EventType.ActionSocketStart, typeof (StartSocketServer));
            controller.AddCommand(EventType.ActionSocketStop, typeof (StopSocketServer));
            controller.AddCommand(EventType.ActionClientConnected, typeof (ClientConnected));
            controller.AddCommand(EventType.ActionClientDisconnected, typeof (ClientDisconnected));
            controller.AddCommand(EventType.ActionForceClientDisconnect, typeof (ForceClientDisconnect));
            controller.AddCommand(EventType.InitializeModel, typeof(InitializeModelStateCommand));
            /** Protocol Related commands **/
            controller.AddCommand(Constants.Player, typeof (RequestPlayer));
            controller.AddCommand(Constants.Protocol, typeof (RequestProtocol));
            controller.AddCommand(Constants.Next, typeof (RequestNextTrack));
            controller.AddCommand(Constants.PlayPause, typeof (RequestPlayPause));
            controller.AddCommand(Constants.Previous, typeof (RequestPreviousTrack));
            controller.AddCommand(Constants.Stop, typeof (RequestStop));
            controller.AddCommand(Constants.Volume, typeof (RequestVolume));
            controller.AddCommand(Constants.SongInformation, typeof (RequestSongInfo));
            controller.AddCommand(Constants.SongCover, typeof (RequestCover));
            controller.AddCommand(Constants.Playlist, typeof(RequestNowPlayingList));
            controller.AddCommand(Constants.PlayNow, typeof (RequestNowPlayingPlay));
            controller.AddCommand(Constants.Lyrics, typeof (RequestLyrics));
            controller.AddCommand(Constants.Rating, typeof (RequestRating));
            controller.AddCommand(Constants.PlayerStatus, typeof (RequestPlayerStatus));
            controller.AddCommand(Constants.PlaybackPosition, typeof (RequestPlaybackPosition));
            controller.AddCommand(Constants.NowPlayingTrackRemoval, typeof (RequestNowPlayingTrackRemoval));
            controller.AddCommand(Constants.AutoDj, typeof (RequestAutoDj));
            controller.AddCommand(Constants.PluginVersion, typeof (RequestPluginVersion));
            controller.AddCommand(Constants.LfmLoveRating, typeof (RequestLfmLoveRating));
            controller.AddCommand(Constants.PlaylistList, typeof (RequestPlaylistList));
            controller.AddCommand(Constants.Shuffle, typeof(RequestShuffle));
            controller.AddCommand(Constants.Scrobble, typeof(RequestScrobble));
            controller.AddCommand(Constants.Repeat, typeof(RequestRepeat));
            controller.AddCommand(Constants.Mute, typeof(RequestMute));
            controller.AddCommand(Constants.NowPlayingSearch, typeof(RequestNowPlayingSearch));
            controller.AddCommand(Constants.LibrarySearch, typeof(RequestLibrarySearch));
            controller.AddCommand(Constants.NowPlayingMoveTrack, typeof(RequestNowPlayingMoveTrack));
            controller.AddCommand(Constants.NowPlayingQueue, typeof(RequestNowPlayingQueue));
            controller.AddCommand(EventType.ReplyAvailable, typeof(ReplayAvailable));
            controller.AddCommand(EventType.PlayerStateTrackChanged, typeof(PTrackChanged));
            controller.AddCommand(EventType.PlayerStateLyricsChanged, typeof (PLyricsChanged));
            controller.AddCommand(EventType.PlayerStateCoverChanged, typeof (PCoverChanged));
        }
    }
}