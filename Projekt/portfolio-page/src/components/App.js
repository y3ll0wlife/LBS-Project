import React, { Component } from "react";
import { BrowserRouter as Router, Route, Switch } from "react-router-dom";
import ParticlesEffect from "./misc/ParticlesEffect";

import _404 from "../pages/_404";

import Homepage from "../pages/Homepage";
import AboutMe from "../pages/AboutMe";
import Projects from "../pages/Projects";
import Contact from "../pages/Contact";

export default class App extends Component {
	render() {
		return (
			<>
				<Router>
					<Switch>
						<Route exact path="/" render={(props) => <Homepage {...props} />} />
						<Route
							exact
							path="/about-me"
							render={(props) => <AboutMe {...props} />}
						/>
						<Route
							exact
							path="/projects"
							render={(props) => <Projects {...props} />}
						/>
						<Route
							exact
							path="/contact"
							render={(props) => <Contact {...props} />}
						/>
						<Route
							path="*"
							// eslint-disable-next-line
							render={(props) => <_404 {...props} />}
						/>
					</Switch>
				</Router>
				<ParticlesEffect />
				<div style={{ paddingBottom: "50px" }} />
			</>
		);
	}
}
