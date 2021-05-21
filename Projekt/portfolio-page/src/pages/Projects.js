import React, { Component } from "react";
import { Button, Container, Row, Col } from "react-bootstrap";

import BulbbotLogo from "../components/assets/bulbbot.png";
import Eclipse from "../components/assets/eclipse.png";
import School from "../components/assets/school.png";

export default class Projects extends Component {
	render() {
		return (
			<>
				<br />

				<div className="center-full">
					<Container>
						<Row md={3}>
							<Col>
								<img
									src={BulbbotLogo}
									alt="bulbbot-logo"
									className="project-logo"
								/>
								<h3>Bulbbot - The Discord Bot</h3>
								<Button
									className="button-homepage"
									variant="dark"
									href="https://github.com/TestersQTs/Bulbbot"
									target="_blank">
									source-code
								</Button>{" "}
								<Button
									className="button-homepage"
									variant="dark"
									href="https://discord.com/oauth2/authorize?client_id=755149065137815623&scope=bot&permissions=1544940655"
									target="_blank">
									invite-bot
								</Button>{" "}
							</Col>
							<Col>
								<img
									src={Eclipse}
									alt="eclipse-logo"
									className="project-logo"
								/>
								<h3>Eclipse</h3>
								<Button
									className="button-homepage"
									variant="dark"
									href="https://github.com/y3ll0wlife/Eclipse"
									target="_blank">
									source-code
								</Button>{" "}
							</Col>
							<Col>
								<img src={School} alt="eclipse-logo" className="project-logo" />
								<h3>School Projects</h3>
								<Button
									className="button-homepage"
									variant="dark"
									href="https://github.com/y3ll0wlife/LBS-Project/tree/main/Projekt"
									target="_blank">
									source-code
								</Button>{" "}
							</Col>
						</Row>
					</Container>
					<Button className="button-homepage" variant="dark" href="/">
						return-back
					</Button>{" "}
				</div>
			</>
		);
	}
}
