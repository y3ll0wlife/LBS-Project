import React, { Component } from "react";
import { Button, Container, Row, Col } from "react-bootstrap";

import Github from "../components/assets/github.png";
import Email from "../components/assets/email.png";
import Twitter from "../components/assets/twitter.png";

export default class Contact extends Component {
	render() {
		return (
			<>
				<br />
				<div className="center-full">
					<Container>
						<Row md={3} style={{ marginLeft: 30 }}>
							<Col>
								<a
									href="https://github.com/y3ll0wlife"
									target="_blank"
									rel="noreferrer">
									<img src={Github} className="contact-logo" alt="github" />
								</a>
							</Col>
							<Col>
								<a href="mailto:y3ll0wlife@protonmail.com">
									<img src={Email} className="contact-logo" alt="email" />
								</a>
							</Col>
							<Col>
								<a
									href="https://twitter.com/y3ll0wLife"
									target="_blank"
									rel="noreferrer">
									<img src={Twitter} className="contact-logo" alt="twitter" />
								</a>
							</Col>
						</Row>
					</Container>
					<Button className="button-homepage" variant="dark" href="/">
						return-back
					</Button>
				</div>
			</>
		);
	}
}
