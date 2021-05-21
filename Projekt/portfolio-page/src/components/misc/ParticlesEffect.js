import React from "react";
import Particles from "react-tsparticles";

function ParticlesEffect() {
	return (
		<Particles
			id="tsparticles"
			options={{
				background: {
					color: {
						value: "#222222",
					},
				},
				fpsLimit: 60,
				interactivity: {
					detectsOn: "canvas",
					events: {
						onClick: {
							enable: true,
							mode: "push",
						},
						onHover: {
							enable: true,
							mode: "repulse",
						},
						resize: true,
					},
					modes: {
						bubble: {
							distance: 200,
							duration: 2,
							opacity: 0,
							size: 40,
						},
						push: {
							quantity: 5,
						},
						repulse: {
							distance: 100,
							duration: 0.1,
						},
					},
				},
				particles: {
					color: {
						value: "#ffffff",
					},
					links: {
						color: "#ffffff",
						distance: 150,
						enable: true,
						opacity: 0.15,
						width: 0.3,
					},
					collisions: {
						enable: true,
					},
					move: {
						direction: "none",
						enable: true,
						outMode: "bounce",
						random: true,
						speed: 2,
						straight: false,
					},
					number: {
						density: {
							enable: true,
							value_area: 800,
						},
						value: 100,
					},
					opacity: {
						value: 0.2,
					},
					shape: {
						type: "circle",
					},
					size: {
						random: true,
						value: 5,
					},
				},
				detectRetina: true,
			}}
		/>
	);
}

export default ParticlesEffect;
