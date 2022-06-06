package com.example.demo2;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
//import org.springframework.context.annotation.ComponentScan; this and the commented-out code below was to fix the "Whitelabel Error Page", but in the end I just moved my pages from /templates to /static. I left these to show (mostly myself) what I was doing.

@SpringBootApplication
//@ComponentScan(basePackages ="/demo2_demo2/src/main/resources/static/index.html" + "/demo2_demo2/src/main/resources/static/about.html" + "/demo2_demo2/src/main/resources/static/resources.html" + "/demo2_demo2/src/main/resources/static/spring.html")
public class Demo2Application {

	public static void main(String[] args) {
		SpringApplication.run(Demo2Application.class, args);
	}

}
