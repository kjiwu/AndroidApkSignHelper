using System;

public class DefaultSignFilesHelper
{
	const string DEFAULT_SIGN_FILE = "sign_info.txt";

	public DefaultSignFilesHelper()
	{
	}

	public static Dictionary<string, string> GetSignConfigItems()
	{
        Dictionary<string, string> items = new Dictionary<string, string> ();
		if (File.Exists(DEFAULT_SIGN_FILE))
		{
            using (StreamReader reader = new StreamReader(DEFAULT_SIGN_FILE))
            {
                if (null != reader)
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] infos = line.Split(new char[] { ',' });
                        items.Add(infos[0], infos[1]);
                    }
                }
            }

        }

        return items;
	}

}
