using System.Collections.Generic;
using ZonyLrcToolsX.Downloader.Lyric;

namespace ZonyLrcToolsX.Infrastructure.Configuration
{
    /// <summary>
    /// 软件的配置信息。
    /// </summary>
    public class AppConfigurationModel
    {
        /// <summary>
        /// 支持的歌曲文件后缀名。
        /// </summary>
        public List<string> SuffixName { get; set; }

        /// <summary>
        /// 存储的歌词文件编码方式。
        /// </summary>
        public int CodePage { get; set; }

        /// <summary>
        /// 是否启用了网络代理功能。
        /// </summary>
        public bool IsEnableProxy { get; set; }

        /// <summary>
        /// 网络代理服务器的 IP。
        /// </summary>
        public string ProxyIp { get; set; }

        /// <summary>
        /// 网络代理服务器的端口号。
        /// </summary>
        public int ProxyPort { get; set; }

        /// <summary>
        /// 如果存在有同名的 Lyric 文件，是否进行覆盖操作。
        /// </summary>
        public bool IsCoverSourceLyricFile { get; set; }

        /// <summary>
        /// 是否自动检测软件更新，启用自动检测则为 True，不启用则为 False。
        /// </summary>
        public bool IsAutoCheckUpdate { get; set; }

        /// <summary>
        /// 下载歌词的内容，请参考 <see cref="LyricContentTypes"/> 枚举类型。
        /// </summary>
        public LyricContentTypes LyricContentType { get; set; }

        /// <summary>
        /// 歌词文件的换行符格式，请参考 <see cref="LineBreakTypes"/> 枚举类型。
        /// </summary>
        public LineBreakTypes LineBreakType { get; set; }

        /// <summary>
        /// 已经选择的歌词下载源。
        /// </summary>
        public LyricDownloaderEnum SelectedLyricDownloader { get; set; }

        /// <summary>
        /// 歌词下载/封面下载的最大线程数。
        /// </summary>
        public int DownloadThreadNumber { get; set; }

        /// <summary>
        /// Mp3Tag 的可执行文件 (exe) 路径。
        /// </summary>
        public string Mp3TagPath { get; set; }

        public AppConfigurationModel()
        {
            SuffixName = new List<string>();
        }
    }
}