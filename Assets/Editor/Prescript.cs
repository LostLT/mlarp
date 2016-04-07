using UnityEngine;
using System;
using System.Collections;
using System.Diagnostics;

public class Prescript
{

	public static void Hackorz()
	{
		Process proc = new Process();

		try 
		{
			proc.StartInfo.FileName = "hacked.sh";
			proc.StartInfo.UseShellExecute = false; 
			proc.Start();
		}catch(Exception e)
		{
			UnityEngine.Debug.Log("Could not set this up because " + e);
		}

	}

}
