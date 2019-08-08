
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GitHubEmojis
{
    public interface IGithubEmojiService
    {

        Task<IList<Emoji>> GetEmojis();
        IList<Emoji> GetEmojisFrom(string content);
    }
}