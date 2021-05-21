import React, { Component } from "react";
import { Button } from "react-bootstrap";

export default class AboutMe extends Component {
	render() {
		return (
			<>
				<br />
				<div className="center-full">
					<h1>
						My name is <strong className="title">Philip</strong>.
					</h1>
					<h3>I am 18 years old and a student studying software development</h3>
					<h3>I build random stuff for fun</h3>
					<Button className="button-homepage" variant="dark" href="/">
						return-back
					</Button>{" "}
				</div>
			</>
		);
	}
}
