
using System;
using MonoDevelop.Core.Serialization;

namespace MonoDevelop.VersionControl
{
	public abstract class UrlBasedRepository: Repository, ICustomDataItem
	{
		string url;
		Uri uri;
		
		public UrlBasedRepository ()
		{
		}
		
		public UrlBasedRepository (VersionControlSystem vcs): base (vcs)
		{
		}
		
		DataCollection ICustomDataItem.Serialize (ITypeSerializer handler)
		{
			return handler.Serialize (this);
		}
		
		void ICustomDataItem.Deserialize (ITypeSerializer handler, DataCollection data)
		{
			handler.Deserialize (this, data);
			if (data["Url"] == null) {
				string dir = ((DataValue)data ["Dir"]).Value;
				string user = ((DataValue)data ["User"]).Value;
				string server = ((DataValue)data ["Server"]).Value;
				string method = ((DataValue)data ["Method"]).Value;
				int port = int.Parse (((DataValue)data ["Port"]).Value);
				UriBuilder ub = new UriBuilder (method, server, port, dir);
				url = ub.ToString ();
			}
			CreateUri ();
		}

		void CreateUri ()
		{
			try {
				uri = new Uri (url);
			} catch {
				uri = null;
			}
		}
		
		public override void CopyConfigurationFrom (Repository other)
		{
			base.CopyConfigurationFrom (other);
			
			UrlBasedRepository ot = (UrlBasedRepository) other;
			url = ot.url;
			CreateUri ();
		}
		
		public abstract string[] SupportedProtocols { get; }
		
		public virtual bool IsUrlValid (string url)
		{
			try {
				Uri uri = new Uri (url);
				return Array.IndexOf (SupportedProtocols, uri.Scheme) != -1;
			} catch {
				return false;
			}
		}

		public override string LocationDescription {
			get { return Url; }
		}
		
		[ItemProperty]
		public virtual string Url
		{
			get { return url; }
			set { url = value; CreateUri (); }
		}
		
		internal Uri Uri {
			get { return uri; }
		}

	}
}
