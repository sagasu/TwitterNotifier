namespace Core

open System.Net
open System.IO
open System.Text.RegularExpressions;
open System
open HtmlAgilityPack
open System.Xml

type public FeedProvider() = 
    member public this.GetRawFeed =
        let url = "http://twitter.com/TrafalgarTalk";

        let req = WebRequest.Create(url)
        let res = req.GetResponse()

        let stream = res.GetResponseStream()
        let reader = new StreamReader(stream)
        let feed = reader.ReadToEnd()
        feed

    member public this.GetTwitts = 
        let feed = this.GetRawFeed
        let html = new HtmlDocument()
        html.LoadHtml(feed)
        let nodes = html.DocumentNode.SelectNodes("//div[@class='content']")
        let data = Seq.fold (fun acc (x:HtmlNode) -> acc + x.InnerHtml) "" (nodes.Nodes())
        data

