namespace Core

type public FeedManager() = 
    member public this.IsModified (originalTwitts:string) = 
        let twitts = this.GetTwitts
        if originalTwitts.CompareTo(twitts) <> 0 then true else false

    member public this.GetTwitts = 
        let feedProvider = new FeedProvider()
        feedProvider.GetTwitts