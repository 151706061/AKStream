using System;
using LibCommon.Enums;
using LibCommon.Structs.DBModels;

namespace LibCommon.Structs
{
    /// <summary>
    /// 音视频通道流媒体信息
    /// </summary>
    [Serializable]
    public class VideoChannelMediaInfo : VideoChannel
    {
        private MediaServerStreamInfo? _mediaServerStreamInfo;
        private StreamSourceType? _streamSourceType;

        public MediaServerStreamInfo? MediaServerStreamInfo
        {
            get => _mediaServerStreamInfo;
            set => _mediaServerStreamInfo = value;
        }

        /// <summary>
        /// 流来源类型
        /// </summary>
        public StreamSourceType? StreamSourceType
        {
            get => _streamSourceType;
            set => _streamSourceType = value;
        }
    }
}