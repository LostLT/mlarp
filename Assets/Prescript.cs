using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class Prescript
{

	public static void Hackorz()
	{
		Process proc = new Process();
		proc.StartInfo.FileName = "hacked.sh";
		//proc.StartInfo.Arguments = "--H";
		proc.StartInfo.UseShellExecute = false; 
		//proc.StartInfo.RedirectStandardErrort = true;
		//proc.StartInfo.RedirectStandardInput = true;
		//proc.StartInfo.RedirectStandardOutput = true;
		proc.Start();
		//var output = proc.RedirectStandardOutput.ReadToEnd();
	}

}
