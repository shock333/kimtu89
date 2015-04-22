using System;
using System.Collections;

public class Mail {
	private string mailContents;
	private string fromWho;


	public Mail (string contents){
		this.mailContents = contents;
	}
	public void setMail (string contents){
		this.mailContents = contents;
	}
	public string getMail (){
		return mailContents;
	}
}
